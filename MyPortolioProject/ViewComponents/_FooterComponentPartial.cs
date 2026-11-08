using Microsoft.AspNetCore.Mvc;

namespace MyPortolioProject.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
