using Microsoft.AspNetCore.Mvc;

namespace MyPortolioProject.ViewComponents
{
    public class _ContactComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
