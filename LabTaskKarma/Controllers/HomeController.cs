using LabTaskKarma.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LabTaskKarma.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            var products = new List<Products>
            {
                new Products {Id = 1, Name = "SomeName1", Price = 340, DiscountPrice = 250, PhotoPath = "p1.jpg"},
                new Products {Id = 2, Name = "SomeName2", Price = 420, DiscountPrice = 300, PhotoPath = "p2.jpg"},
                new Products {Id = 3, Name = "SomeName3", Price = 700, DiscountPrice = 550, PhotoPath = "p3.jpg"},
                new Products {Id = 4, Name = "SomeName4", Price = 550, DiscountPrice = 500, PhotoPath = "p4.jpg"},
                new Products {Id = 5, Name = "SomeName5", Price = 610, DiscountPrice = 450, PhotoPath = "p5.jpg"},
                new Products {Id = 6, Name = "SomeName6", Price = 500, DiscountPrice = 350, PhotoPath = "p6.jpg"},
                new Products {Id = 7, Name = "SomeName7", Price = 450, DiscountPrice = 250, PhotoPath = "p7.jpg"},
                new Products {Id = 8, Name = "SomeName8", Price = 900, DiscountPrice = 250, PhotoPath = "p8.jpg"}
            };
            
            return View(products);
        }
    }
}
