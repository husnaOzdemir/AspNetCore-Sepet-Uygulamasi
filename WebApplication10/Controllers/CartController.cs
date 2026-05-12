using Microsoft.AspNetCore.Mvc;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class CartController : Controller
    {
        static string sessionKey = "Sepet";
        public IActionResult Index()
        {
            var items = HttpContext.Session.Get<List<Product>>(sessionKey);
            if (items==null)
            {
                items = new List<Product>();
            }

            List<string> otherData = new List<string>();
            ViewBag.OtherData = otherData;
            return View(items);
        }

        public IActionResult Add(int id)
        {
            var items = HttpContext.Session.Get<List<Product>>(sessionKey);
            if (items == null)
            {
                items = new List<Product>();
            }

            var allProducts = ProductsController.Products;
            var selectedItem = allProducts.FirstOrDefault(x=> x.Id == id);

            if (selectedItem == null)
            {
                return RedirectToAction(nameof(Index));
            }

            items.Add(selectedItem);
            HttpContext.Session.Set<List<Product>>(sessionKey, items);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int id) {
            var items = HttpContext.Session.Get<List<Product>>(sessionKey);

            if (items == null)
                return RedirectToAction(nameof(Index));

            items = items.Where(x => x.Id != id).ToList();
            HttpContext.Session.Set<List<Product>>(sessionKey, items);

            return RedirectToAction(nameof(Index));
        }
    }
}
