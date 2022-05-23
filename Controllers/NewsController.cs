using F1.Data;
using F1.Interfaces;
using F1.Models;
using F1.SignalR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace F1.Controllers
{
    public class NewsController : Controller
    {

        private readonly IGetNews _getNews;
        private SiteContext db;
        IHubContext<ChatHub> hubContext;

        public NewsController(IGetNews getNews, SiteContext siteContext, IHubContext<ChatHub> hubContext)
        {
            _getNews = getNews;
            db = siteContext;
            this.hubContext = hubContext;
        }

        public ActionResult Index()
        {
            var news = _getNews.GetAllNews;
            return View(news);
        }

        public IActionResult Details(int id)
        {
            if (id != 0)
            {
                New article  = _getNews.GetObjectNew(id);

                return View(article);
            }


            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> Create(New article)
        {
            db.New.Add(article);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        [Authorize(Roles = "editor")]
        [HttpGet, ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            if (id != 0)
            {
                New article = _getNews.GetObjectNew(id);
                if (article != null)
                    return View(article);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                New article = new New { Id = id.Value };
                db.Entry(article).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return NotFound();
        }


        [Authorize(Roles = "editor")]
        public async Task<IActionResult> Edit(int id)
        {
            if (id != 0)
            {
                New article = _getNews.GetObjectNew(id);
                if (article != null)
                {
                    DataClass.TempNew = article;
                    return View(article);
                }
            }
            else
            {
                New article = new New();
                article.Name = "New article";
                DataClass.TempNew = article;
                return View(article);
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(New article)
        {
            NewArticle(article);

            await db.SaveChangesAsync();
            DataClass.TempNew = null;
            return RedirectToAction("Index");
        }
        [HttpPost]
        public void NewArticle(New article)
        {
            db.New.Update(article);
            db.SaveChanges();
        }

        [Authorize]
        public IActionResult Chat()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SendChat(string message)
        {
            await hubContext.Clients.All.SendAsync("Send", $"{User.Identity.Name}: {message} - {DateTime.Now.ToShortTimeString()}");
            return RedirectToAction("Index");
        }

    }
}
