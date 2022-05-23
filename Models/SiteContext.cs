using System;
using System.Collections.Generic;
using System.Text;
using F1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace F1.Data
{
    public class SiteContext : IdentityDbContext<User>
    {
        public DbSet<Team> Team { get; set; }
        public DbSet<Driver> Driver { get; set; }
        public DbSet<Race> Race { get; set; }
        public DbSet<New> New { get; set; }
        public DbSet<RaceResult> RaceResult { get; set; }

        public SiteContext(DbContextOptions<SiteContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}