using Microsoft.AspNetCore.Mvc;
using WebApplication10.Data;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class ProductsController : Controller
    {
        private IDatabase _database;
        public ProductsController(IDatabase database)
        {
            _database = database;
        }

        public static List<Product> Products = new List<Product> { 
        new Product{ Id=1, Name = "Terlik", Price = 180},
        new Product{ Id=2, Name = "Ayakkabı", Price = 4000},
        new Product{ Id=3, Name = "Çizme", Price = 5000},
        };

        public IActionResult Index()
        {

            return View(Products);
        }
    }
}
