using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;
using System.Linq;

namespace MyPortolioProject.ViewComponents
{
    public class _WorkComponentPartial : ViewComponent
    {
        private readonly MyPortfolioContext context = new();

        public IViewComponentResult Invoke()
        {
            var portfolios = context.Portfolios.ToList();
            return View(portfolios);
        }
    }
}

