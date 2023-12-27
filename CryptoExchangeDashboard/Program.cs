namespace CryptoExchangeDashboard
{
    public class Program
    {
        private static string HOST_URL = "http://*:5000";
        public static void Main(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(x => x.UseUrls(HOST_URL))
                .ConfigureWebHostDefaults(builder =>
            {
                builder.UseStartup<Startup>();
            });

            var app = builder.Build();



            app.Run();
        }



    }
}