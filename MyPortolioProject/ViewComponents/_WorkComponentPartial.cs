using Microsoft.AspNetCore.Mvc;

namespace MyPortolioProject.ViewComponents
{
    public class _WorkComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

