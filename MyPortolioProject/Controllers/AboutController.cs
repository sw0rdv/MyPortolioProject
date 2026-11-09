using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;
using MyPortolioProject.DAL.Entity;

namespace MyPortolioProject.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        [HttpGet]
        public IActionResult Index()
        {
            var values = context.Abouts.FirstOrDefault();
            return View(values ?? new About());
        }
        [HttpPost]
        public IActionResult Index(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

