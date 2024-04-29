using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Guitar_Collection.Data;
using CIT_195_Lesson_11_Guitar_Collection.Models;
namespace CIT_195_Lesson_11_Guitar_Collection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<CIT_195_Lesson_11_Guitar_CollectionContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("CIT_195_Lesson_11_Guitar_CollectionContext") ?? throw new InvalidOperationException("Connection string 'CIT_195_Lesson_11_Guitar_CollectionContext' not found.")));

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                SeedData.Initialize(services);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
