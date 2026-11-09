using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;
using MyPortolioProject.DAL.Entity;

namespace MyPortolioProject.Controllers
{
    public class PortfolioController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Index()
        {
            var values = context.Portfolios.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var portfolio = context.Portfolios.Find(id);
            if (portfolio != null)
            {
                context.Portfolios.Remove(portfolio);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var portfolio = context.Portfolios.Find(id);
            if (portfolio == null) return RedirectToAction("Index");
            return View(portfolio);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}