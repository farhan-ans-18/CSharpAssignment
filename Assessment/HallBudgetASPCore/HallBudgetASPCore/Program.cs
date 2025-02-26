using HallBudgetASPCore.Models;
using Microsoft.EntityFrameworkCore;

namespace HallBudgetASPCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<HallDbContext>(opts => opts.UseNpgsql("Host=localhost;Database=myDb;Username=postgres;Password=Izhar@927"));
            builder.Services.AddScoped<IHallDataAccessModel, HallDataAccess>();
            builder.Services.AddSession();
           
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
