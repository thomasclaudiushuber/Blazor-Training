using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using ThomasClaudiusHuber.DependencyInjection.Services;

namespace ThomasClaudiusHuber.DependencyInjection
{
  public class Program
  {
    public static async Task Main(string[] args)
    {
      var builder = WebAssemblyHostBuilder.CreateDefault(args);
      builder.RootComponents.Add<App>("#app");

      builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
      
      // TODO: 1. Add the EmployeeService here as a singleton, register it as IEmployeeService

      await builder.Build().RunAsync();
    }
  }
}
