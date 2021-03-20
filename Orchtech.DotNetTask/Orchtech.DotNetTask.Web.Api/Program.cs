using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Orchtech.DotNetTask.Web.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilders(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilders(string[] args) =>
             WebHost.CreateDefaultBuilder(args)
                 .UseStartup<Startup>();
    }
}
