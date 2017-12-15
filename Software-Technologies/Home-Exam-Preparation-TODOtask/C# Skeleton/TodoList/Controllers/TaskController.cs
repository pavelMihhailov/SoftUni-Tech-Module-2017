using System;
using System.Linq;
using System.Web.Mvc;
using TodoList.Models;

namespace TodoList.Controllers
{
        [ValidateInput(false)]
	public class TaskController : Controller
	{
	    [HttpGet]
        [Route("")]
	    public ActionResult Index()
	    {
	        using (var database = new TodoListDbContext())
	        {
	            var tasks = database.Tasks.ToList();
	            return View(tasks);
	        }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

		[HttpPost]
		[Route("create")]
        [ValidateAntiForgeryToken]
		public ActionResult Create(Task task)
		{
		    if (ModelState.IsValid)
		    {
		        using (var database = new TodoListDbContext())
		        {
		            database.Tasks.Add(task);
		            database.SaveChanges();
		        }
		    }
		    return RedirectToAction("Index");
        }

		[HttpGet]
		[Route("delete/{id}")]
        public ActionResult Delete(int id)
		{
		    if (id == null)
		    {
		        return HttpNotFound();
		    }

		    using (var database = new TodoListDbContext())
		    {
		        Task task = database.Tasks.Find(id);

		        if (task == null)
		        {
		            return RedirectToAction("Index");
		        }
		        return View(task);
		    }
        }

		[HttpPost]
		[Route("delete/{id}")]
        [ValidateAntiForgeryToken]
		public ActionResult DeleteConfirm(int id)
		{
		    if (id == null) return HttpNotFound();

		    using (var database = new TodoListDbContext())
		    {
		        Task taskToBeDeleted = database.Tasks.Find(id);

		        if (taskToBeDeleted == null) return RedirectToAction("Index");

		        database.Tasks.Remove(taskToBeDeleted);
		        database.SaveChanges();
		    }

		    return RedirectToAction("Index");
        }
	}
}