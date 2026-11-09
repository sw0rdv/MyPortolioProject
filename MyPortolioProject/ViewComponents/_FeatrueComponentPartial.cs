using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;

namespace MyPortolioProject.ViewComponents
{
    public class _FeatrueComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = portfolioContext.Features.ToList();
            ViewBag.HeroImageUrl = portfolioContext.Abouts
                .Select(x => x.ImageUrl)
                .FirstOrDefault();
            return View(value );
        }
    }
}
