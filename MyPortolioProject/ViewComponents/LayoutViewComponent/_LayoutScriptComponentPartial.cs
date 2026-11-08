using Microsoft.AspNetCore.Mvc;

namespace MyPortolioProject.ViewComponents.LayoutViewComponent
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    
    }
}
