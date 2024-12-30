namespace WebStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            var configuration = app.Configuration;

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
