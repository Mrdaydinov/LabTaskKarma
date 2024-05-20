using LabTaskKarma.Models;
using LabTaskKarma.Models.Entities;

namespace LabTaskKarma.ViewModels
{
    public class PopularPostsCategoryModel
    {
        public List<PopularPosts> PopularPosts { get; set; }

        public List<BlogCategory> BlogCategories { get; set; }

        public List<BlogPost> BlogPosts { get; set; }
    }
}
