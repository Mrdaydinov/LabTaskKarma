using LabTaskKarma.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabTaskKarma.Controllers
{
    public class ShopController : Controller
    {

        public IActionResult Index()
        {
            var categories = new List<ShopCategories>
            {
                new ShopCategories {Id=1, Title= "SomeCategory1", ProductCount = 10},
                new ShopCategories {Id=2, Title= "SomeCategory2", ProductCount = 16},
                new ShopCategories {Id=3, Title= "SomeCategory3", ProductCount = 14},
                new ShopCategories {Id=4, Title= "SomeCategory4", ProductCount = 12},
                new ShopCategories {Id=5, Title= "SomeCategory5", ProductCount = 17},
                new ShopCategories {Id=6, Title= "SomeCategory6", ProductCount = 21},
                new ShopCategories {Id=7, Title= "SomeCategory7", ProductCount = 10},
                new ShopCategories {Id=8, Title= "SomeCategory8", ProductCount = 39},
                new ShopCategories {Id=9, Title= "SomeCategory9", ProductCount = 40},
                new ShopCategories {Id=10, Title= "SomeCategory10", ProductCount = 32},
                new ShopCategories {Id=11, Title= "SomeCategory11", ProductCount = 29},
                new ShopCategories {Id=12, Title= "SomeCategory12", ProductCount = 19},
            };

            return View(categories);
        }
    }
}
