using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;

namespace MyPortolioProject.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}

