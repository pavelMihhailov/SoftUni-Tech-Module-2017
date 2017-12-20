using System.Linq;
using System.Web.Mvc;
using AnimeList.Models;

namespace AnimeList.Controllers
{
    [ValidateInput(false)]
    public class AnimeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var database = new AnimeListDbContext())
            {
                var animes = database.Animes.ToList();
                return View(animes);
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
        public ActionResult Create(Anime anime)
        {
            if (ModelState.IsValid)
            {
                using (var database = new AnimeListDbContext())
                {
                    database.Animes.Add(anime);
                    database.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            using (var database = new AnimeListDbContext())
            {
                Anime anime = database.Animes.Find(id);

                if (anime == null)
                {
                    return RedirectToAction("Index");
                }
                return View(anime);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Anime animeModel)
        {
            if (id == null) return HttpNotFound();

            using (var database = new AnimeListDbContext())
            {
                Anime animeToBeDeleted = database.Animes.Find(id);

                if (animeToBeDeleted == null) return RedirectToAction("Index");

                database.Animes.Remove(animeToBeDeleted);
                database.SaveChanges();
            }

            return RedirectToAction("Index");

        }
    }
}