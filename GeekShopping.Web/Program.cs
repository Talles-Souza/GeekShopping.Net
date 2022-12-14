using GeekShopping.Web.Services.IServices;

namespace GeekShopping.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            
            AppDomain currentDomain = AppDomain.CurrentDomain;
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddMvc();
            builder.Services.AddHttpClient<IProductService, ProductService>(c =>
            c.BaseAddress = new Uri("http://localhost:4440"));  
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
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