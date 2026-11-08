using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;

namespace MyPortolioProject.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext db = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.ExperienceCount = db.Experiences.Count();
            ViewBag.SkillCount = db.Skills.Count();
            ViewBag.PortfolioCount = db.Portfolios.Count();
            ViewBag.TestimonialCount = db.Testimonials.Count();
            ViewBag.MessageCount = db.Messages.Count();
            ViewBag.MessageCountV2 = db.Messages.Where(x => x.Isread == false).Count();
            ViewBag.SocialMediaCount = db.SocialMedias.Count();
            ViewBag.FeatureCount = db.Features.Count();
            ViewBag.LastExperience = db.Experiences.OrderByDescending(e => e.Date).FirstOrDefault()?.Title;
            return View();
        }
    }
}
