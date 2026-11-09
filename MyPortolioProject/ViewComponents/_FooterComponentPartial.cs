using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;
using System.Linq;

namespace MyPortolioProject.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        private readonly MyPortfolioContext context = new();

        public IViewComponentResult Invoke()
        {
            var socialMedias = context.SocialMedias.ToList();
            return View(socialMedias);
        }
    }
}
