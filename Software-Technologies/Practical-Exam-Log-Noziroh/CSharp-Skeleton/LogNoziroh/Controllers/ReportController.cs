namespace LogNoziroh.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Models;

    [ValidateInput(false)]
    public class ReportController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var database = new LogNozirohDbContext())
            {
                var reports = database.Reports.ToList();
                return View(reports);
            }
        }

        [HttpGet]
        [Route("details/{id}")]
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            using (var database = new LogNozirohDbContext())
            {
                Report report = database.Reports.Find(id);

                if (report == null)
                {
                    return RedirectToAction("Index");
                }
                return View(report);
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
        public ActionResult Create(Report report)
        {
            if (ModelState.IsValid)
            {
                using (var database = new LogNozirohDbContext())
                {
                    database.Reports.Add(report);
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

            using (var database = new LogNozirohDbContext())
            {
                Report report = database.Reports.Find(id);

                if (report == null)
                {
                    return RedirectToAction("Index");
                }
                return View(report);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Report reportModel)
        {
            if (id == null) return HttpNotFound();

            using (var database = new LogNozirohDbContext())
            {
                Report reportToBeDeleted = database.Reports.Find(id);

                if (reportToBeDeleted == null) return RedirectToAction("Index");

                database.Reports.Remove(reportToBeDeleted);
                database.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}