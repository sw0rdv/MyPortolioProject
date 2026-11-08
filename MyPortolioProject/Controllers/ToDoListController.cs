using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace MyPortolioProject.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortolioProject.DAL.Context.MyPortfolioContext context = new MyPortolioProject.DAL.Context.MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddToDoList()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddToDoList(MyPortolioProject.DAL.Entitiy.ToDoList toDoList)
        {
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var values = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var values = context.ToDoLists.Find(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateToDoList(MyPortolioProject.DAL.Entitiy.ToDoList toDoList)
        {
            context.ToDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusTrue(int id)
        {
            var values = context.ToDoLists.Find(id);
            values.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusFalse(int id)
        {
            var values = context.ToDoLists.Find(id);
            values.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
