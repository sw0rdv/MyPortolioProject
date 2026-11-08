using Microsoft.AspNetCore.Mvc;

namespace MyPortolioProject.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
