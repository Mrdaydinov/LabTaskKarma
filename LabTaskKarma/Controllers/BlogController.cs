using LabTaskKarma.Models;
using LabTaskKarma.Models.Entities;
using LabTaskKarma.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LabTaskKarma.Controllers
{
    public class BlogController : Controller
    {
        private readonly DataContext _context;

        public BlogController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var blogCategory = new List<BlogCategory>
            {
                new BlogCategory{Id =1, Title = "SomeTitle1", Description = "SomeDescription1", PhotoPath = "cat-post-3.jpg"},
                new BlogCategory{Id =2, Title = "SomeTitle2", Description = "SomeDescription2", PhotoPath = "cat-post-2.jpg"},
                new BlogCategory{Id =3, Title = "SomeTitle3", Description = "SomeDescription3", PhotoPath = "cat-post-1.jpg"},
            };

            var popularPosts = new List<PopularPosts>
            {
                new PopularPosts{Id = 1, Title = "SomeTitle1", HoursAgoPosted = 1, PhotoPath = "post1.jpg"},
                new PopularPosts{Id = 2, Title = "SomeTitle2", HoursAgoPosted = 2, PhotoPath = "post2.jpg"},
                new PopularPosts{Id = 3, Title = "SomeTitle3", HoursAgoPosted = 3, PhotoPath = "post3.jpg"},
                new PopularPosts{Id = 4, Title = "SomeTitle4", HoursAgoPosted = 4, PhotoPath = "post4.jpg"},
            };


            var blogPosts = _context.BlogPosts.ToList();

            var postsCategoryVM = new PopularPostsCategoryModel();
            postsCategoryVM.BlogCategories = blogCategory;
            postsCategoryVM.PopularPosts = popularPosts;
            postsCategoryVM.BlogPosts = blogPosts;
            return View(postsCategoryVM);
        }
    }
}
