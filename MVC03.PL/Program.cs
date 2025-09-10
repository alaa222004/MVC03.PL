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
            builder.Services.AddScoped<DepartmentsService>();
            builder.Services.AddScoped<DepartmentsRepository>();
            //builder.Services.AddScoped<CompanyDbContext>(Provider=>
            //(
            //);

            //builder.Services.AddDbContext<CompanyDbContext>(options=>
            //{
            //    options.UseSqlServer("");
            //}
            //);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }

        private class DepartmentsRepository
        {
        }

        private class CompanyDbContext
        {
        }
    }
}
