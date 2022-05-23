using F1.Data;
using F1.Interfaces;
using F1.Models;
using F1.Repositories;
using F1.SignalR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace F1
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<SiteContext>(options =>
                options.UseSqlServer(connection));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<SiteContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IGetTeams, TeamRepository>();
            services.AddTransient<IGetDrivers, DriverRepository>();
            services.AddTransient<IGetRaceResults, RaceResultRepository>();
            services.AddTransient<IGetRaces, RaceRepository>();
            services.AddTransient<IGetNews, NewRepository>();

            services.AddSignalR();

            services.AddSingleton<IEmailConfiguration>(new EmailConfiguration
            {
                SmtpServer = Configuration["EmailConfiguration:SmtpServer"],
                SmtpPort = int.Parse(Configuration["EmailConfiguration:SmtpPort"]),
                SmtpUsername = Configuration["EmailConfiguration:SmtpUsername"],
                SmtpPassword = Configuration["EmailConfiguration:SmtpPassword"]
            });

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            
            using (var scope = app.ApplicationServices.CreateScope())
            {
                SiteContext context = scope.ServiceProvider.GetRequiredService<SiteContext>();
                DataClass.Initialize(context);

                var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
                var rolesManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
                RoleInitializer.InitializeAsync(userManager, rolesManager);
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chat");
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapDefaultControllerRoute();
               
            });
        }
    }
}
