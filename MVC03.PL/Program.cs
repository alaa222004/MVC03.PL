using DEM_DAR.Context;
using DEM_DAR.Repositories;
using Demo.BL.Services;
using Microsoft.EntityFrameworkCore;



namespace MVC03.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Service DI
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();

            // Repository DI
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            // DbContext
            builder.Services.AddDbContext<CompanyDbContext>(options =>
            {
                var connection = builder.Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connection);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
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
