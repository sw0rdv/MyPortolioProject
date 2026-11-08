using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;

namespace MyPortolioProject.Controllers
{
    public class MessageController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        public IActionResult Inbox()
        {
            var values = context.Messages
                .OrderByDescending(x => x.SendDate)
                .ToList();
            return View(values);
        }

        public IActionResult ChangeReadStatusTrue(int id)
        {
            var value = context.Messages.Find(id);
            if (value != null)
            {
                value.Isread = true;
                context.SaveChanges();
            }
            return RedirectToAction("Inbox");
        }

        public IActionResult ChangeReadStatusFalse(int id)
        {
            var value = context.Messages.Find(id);
            if (value != null)
            {
                value.Isread = false;
                context.SaveChanges();
            }
            return RedirectToAction("Inbox");
        }
        
        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public IActionResult MessageDetails(int id)
        {
            var value = context.Messages.Find(id);
            return View(value);
        }
}
}