using CVSHealth.IAM.IAPF.Tools.WebCoreUtility.Common.Configuration;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Text.Json;


namespace CVSHealth.IAM.IAPF.Test.BlazorAppTest.Client
{
    public class Program
    {
        public static async Task Main(String[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            var httpClient = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
            var response = await httpClient.GetStringAsync("api/Configuration");
            var settings = JsonSerializer.Deserialize<ClientAppSettings>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            var startup = new Startup();
            startup.ConfigureServices(builder.Services, settings!);

            await builder.Build().RunAsync();
        }
    }
}


