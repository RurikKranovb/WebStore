using Microsoft.AspNetCore.StaticFiles.Infrastructure;

namespace WebStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            var service = builder.Services;

            var configuration = app.Configuration;


             //service.AddMvc

            //app.MapGet("/", () => "Hello World!");

            if (builder.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
             


            app.UseStaticFiles();
            app.UseDefaultFiles();

            app.UseRouting();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/greetings", async context =>
                {
                    await context.Response.WriteAsync(configuration["CustomGreetings"]);
                });

                endpoints.MapControllerRoute(
                    name:"default",
                    pattern: "{controller=Home}/{action=Index}/{id?}" //
                    );
            });

            app.Run();
        }
    }
}
