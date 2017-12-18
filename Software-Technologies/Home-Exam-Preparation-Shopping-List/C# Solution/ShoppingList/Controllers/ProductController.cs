using System.Linq;
using System.Web.Mvc;
using ShoppingList.Models;

namespace ShoppingList.Controllers
{
    [ValidateInput(false)]
    public class ProductController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var database = new ShoppingListDbContext())
            {
                var products = database.Products.ToList();
                return View(products);
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
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                using (var database = new ShoppingListDbContext())
                {
                    database.Products.Add(product);
                    database.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            using (var database = new ShoppingListDbContext())
            {
                Product product = database.Products.Find(id);

                if (product == null)
                {
                    return RedirectToAction("Index");
                }
                return View(product);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int? id, Product productModel)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            if (ModelState.IsValid)
            {
                using (var database = new ShoppingListDbContext())
                {
                    Product productFromDb = database.Products.Find(id);

                    if (productFromDb == null)
                    {
                        return RedirectToAction("Index");
                    }
                    productFromDb.Name = productModel.Name;
                    productFromDb.Priority = productModel.Priority;
                    productFromDb.Quantity = productModel.Quantity;
                    productFromDb.Status = productModel.Status;

                    database.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}