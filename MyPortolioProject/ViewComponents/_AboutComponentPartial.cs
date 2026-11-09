using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;

namespace MyPortolioProject.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.AboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.AboutDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.AboutDetails = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            ViewBag.AboutImageUrl = portfolioContext.Abouts.Select(x => x.ImageUrl).FirstOrDefault();
            return View();
        }
    }
}

