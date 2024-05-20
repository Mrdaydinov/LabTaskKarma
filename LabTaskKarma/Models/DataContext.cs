using LabTaskKarma.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LabTaskKarma.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
