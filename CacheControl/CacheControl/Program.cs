namespace CacheControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            //builder.Services.AddResponseCaching(); // Not required if we are just using public, max-age            

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseStaticFiles(); // For index.html. Need to create a folder wwwroot and put index.html there

            //app.UseResponseCaching();

            app.MapControllers();

            app.Run();
        }
    }
}