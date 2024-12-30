using Microsoft.AspNetCore.StaticFiles.Infrastructure;

namespace WebStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            var configuration = app.Configuration;

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
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(configuration["CustomGreetings"]);
                });
            });

            app.Run();
        }
    }
}
