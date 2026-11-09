using System.Net;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;

namespace MyPortolioProject.Controllers
{
    public class CvController : Controller
    {
        private readonly MyPortfolioContext context = new();

        public IActionResult Download()
        {
            var about = context.Abouts.FirstOrDefault();
            var skills = context.Skills.OrderByDescending(skill => skill.Value).ToList();
            var experiences = context.Experiences.OrderByDescending(experience => experience.ExperienceId).ToList();
            var portfolios = context.Portfolios.ToList();

            var html = new StringBuilder();
            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html lang=\"tr\"><head><meta charset=\"utf-8\"><title>CV</title>");
            html.AppendLine("<style>body{font-family:Arial,sans-serif;max-width:850px;margin:40px auto;color:#222;line-height:1.6}h1{margin-bottom:4px}h2{border-bottom:2px solid #222;padding-bottom:4px;margin-top:28px}.item{margin-bottom:18px}.date{color:#666}.skill{display:inline-block;margin:4px 8px 4px 0;padding:4px 8px;border:1px solid #ccc;border-radius:4px}</style></head><body>");

            var aboutTitle = about?.Title ?? "CV";
            html.AppendLine($"<h1>{Encode(aboutTitle)}</h1>");
            if (!string.IsNullOrWhiteSpace(about?.SubDescription))
            {
                html.AppendLine($"<p>{Encode(about.SubDescription)}</p>");
            }

            if (!string.IsNullOrWhiteSpace(about?.Details))
            {
                html.AppendLine("<h2>Hakkýmda</h2>");
                html.AppendLine($"<p>{Encode(about.Details)}</p>");
            }

            if (experiences.Count > 0)
            {
                html.AppendLine("<h2>Ýþ Deneyimleri</h2>");
                foreach (var experience in experiences)
                {
                    html.AppendLine("<div class=\"item\">");
                    html.AppendLine($"<h3>{Encode(experience.Head)}</h3>");
                    html.AppendLine($"<strong>{Encode(experience.Title)}</strong> <span class=\"date\">{Encode(experience.Date)}</span>");
                    html.AppendLine($"<p>{Encode(experience.Description)}</p></div>");
                }
            }

            if (skills.Count > 0)
            {
                html.AppendLine("<h2>Yetenekler</h2>");
                foreach (var skill in skills)
                {
                    html.AppendLine($"<span class=\"skill\">{Encode(skill.SkillTitle)} %{skill.Value}</span>");
                }
            }

            if (portfolios.Count > 0)
            {
                html.AppendLine("<h2>Portfolyo</h2>");
                foreach (var portfolio in portfolios)
                {
                    html.AppendLine($"<div class=\"item\"><h3>{Encode(portfolio.Title)}</h3><p>{Encode(portfolio.SubTitle)}</p><p>{Encode(portfolio.Description)}</p></div>");
                }
            }

            html.AppendLine("</body></html>");

            return File(Encoding.UTF8.GetBytes(html.ToString()), "text/html", "cv.html");
        }

        private static string Encode(string? value)
        {
            return WebUtility.HtmlEncode(value ?? string.Empty).Replace("\r\n", "<br>").Replace("\n", "<br>");
        }
    }
}
