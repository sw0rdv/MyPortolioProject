using Microsoft.AspNetCore.Mvc;

namespace MyPortolioProject.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
