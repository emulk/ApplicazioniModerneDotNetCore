namespace RazorApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
           .ConfigureWebHostDefaults(x => x.UseUrls("http://*:5001"))
           .UseWindowsService(options =>
           {
               options.ServiceName = "Razor Web App";
           })
           .ConfigureWebHostDefaults(webBuilder =>
           {
               webBuilder.UseStartup<Startup>();
           });
    }
}