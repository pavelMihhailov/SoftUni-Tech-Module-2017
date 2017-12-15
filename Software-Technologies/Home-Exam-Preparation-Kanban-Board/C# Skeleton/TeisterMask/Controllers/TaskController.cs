using System;
using System.Linq;
using System.Web.Mvc;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
        [ValidateInput(false)]
	public class TaskController : Controller
	{
	    [HttpGet]
            [Route("")]
	    public ActionResult Index()
	    {
	        using (var database = new TeisterMaskDbContext())
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
		        using (var database = new TeisterMaskDbContext())
		        {
		            database.Tasks.Add(task);
		            database.SaveChanges();
		        }
		    }
		    return RedirectToAction("Index");
        }

		[HttpGet]
		[Route("edit/{id}")]
        public ActionResult Edit(int id)
		{
		    if (id == null)
		    {
		        return HttpNotFound();
		    }

		    using (var database = new TeisterMaskDbContext())
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
		[Route("edit/{id}")]
        [ValidateAntiForgeryToken]
		public ActionResult EditConfirm(int id, Task taskModel)
		{
		    if (id == null)
		    {
		        return HttpNotFound();
		    }

		    if (ModelState.IsValid)
		    {
		        using (var database = new TeisterMaskDbContext())
		        {
		            Task taskFromDb = database.Tasks.Find(id);

		            if (taskFromDb == null)
		            {
		                return RedirectToAction("Index");
		            }
		            taskFromDb.Status = taskModel.Status;
		            taskFromDb.Title = taskModel.Title;

		            database.SaveChanges();
		        }
		    }
		    return RedirectToAction("Index");
        }
    }
}