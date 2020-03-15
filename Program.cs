using Microsoft.AspNetCore.Blazor.Hosting;

namespace blazor_app
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
            //.UseUrls("http://localhost:5050")
            .Build()
            .Run();
        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();
    }
}
