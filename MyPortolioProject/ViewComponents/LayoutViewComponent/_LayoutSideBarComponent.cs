using Microsoft.AspNetCore.Mvc;

namespace MyPortolioProject.ViewComponents.LayoutViewComponent
{
    public class _LayoutSideBarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
