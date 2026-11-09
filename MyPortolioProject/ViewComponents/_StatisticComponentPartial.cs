using Microsoft.AspNetCore.Mvc;

using MyPortolioProject.DAL.Context;
using MyPortolioProject.Models;

namespace MyPortolioProject.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        private readonly MyPortfolioContext context = new();

        public IViewComponentResult Invoke()
        {
            var statistics = new StatisticViewModel
            {
                SkillsCount = context.Skills.Count(),
                ExperiencesCount = context.Experiences.Count(),
                PortfoliosCount = context.Portfolios.Count(),
                TestimonialsCount = context.Testimonials.Count()
            };

            return View(statistics);
        }

    }
}
