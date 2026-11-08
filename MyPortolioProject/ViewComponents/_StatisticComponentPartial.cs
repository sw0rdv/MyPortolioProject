using Microsoft.AspNetCore.Mvc;

namespace MyPortolioProject.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
