using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

//the service runs with system dependencies that enable the prediction controller to do its thing
//
namespace WebApi
{

    //the main namespace is what holds the builder to the web hosting service.

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
