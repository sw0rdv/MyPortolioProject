using Microsoft.AspNetCore.Mvc;
using MyPortolioProject.DAL.Context;
using MyPortolioProject.DAL.Entity;

namespace MyPortolioProject.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();

        [HttpGet]
        public IActionResult Index()
        {
            var values = context.Contacts.FirstOrDefault();
            return View(values ?? new Contact());
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            if (contact.ContactId == 0)
            {
                context.Contacts.Add(contact);
            }
            else
            {
                context.Contacts.Update(contact);
            }

            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}