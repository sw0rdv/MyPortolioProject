using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;
using System.Linq;

namespace MyPortolioProject.ViewComponents
{
    public class _ContactComponentPartial: ViewComponent
    {
        private readonly MyPortfolioContext context = new();

        public IViewComponentResult Invoke()
        {
            var contact = context.Contacts.FirstOrDefault();
            return View(contact);
        }
    }
}
