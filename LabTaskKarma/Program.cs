using LabTaskKarma.Models;
using Microsoft.EntityFrameworkCore;

namespace LabTaskKarma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<DataContext>(options =>
                            options.UseSqlite(builder.Configuration.GetConnectionString("SqliteCString")));


            var app = builder.Build();

            app.UseStaticFiles();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}