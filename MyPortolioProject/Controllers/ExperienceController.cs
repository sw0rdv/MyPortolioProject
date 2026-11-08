using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;
using MyPortolioProject.DAL.Entity;

namespace MyPortolioProject.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var experience = context.Experiences.Find(id);
                context.Experiences.Remove(experience);
                context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var experience = context.Experiences.Find(id);
            return View(experience);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            var existingExperience = context.Experiences.Find(experience.ExperienceId);
            if (existingExperience != null)
            {
                existingExperience.Head = experience.Head;
                existingExperience.Title = experience.Title;
                existingExperience.Date = experience.Date;
                existingExperience.Description = experience.Description;
                context.SaveChanges();
            }
            return RedirectToAction("ExperienceList");
        }
    }
}