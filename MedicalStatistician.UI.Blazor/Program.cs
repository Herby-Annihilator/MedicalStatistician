using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Entities.Base;
using MedicalStatistician.DAL.Entities.DbContexts;
using MedicalStatistician.DAL.Repositories.Base;
using MedicalStatistician.DAL.Repositories.EfCore;
using MedicalStatistician.UI.Blazor;
using MedicalStatistician.WebApiClients.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;


namespace MedicalStatistician.UI.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            //builder.RootComponents.Add<HeadOutlet>("head::after");
            var services = builder.Services;
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            InitializeRepositories(services);
            await builder.Build().RunAsync();
        }
        private static void InitializeRepositories(IServiceCollection services)
        {
            services.AddHttpClient<ICrudRepository<MKB10>, WebRepository<MKB10>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/MKB10"));

            services.AddHttpClient<ICrudRepository<Sex>, WebRepository<Sex>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/Sex"));
            services.AddHttpClient<ICrudRepository<DisabilityGroup>, WebRepository<DisabilityGroup>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/DisabilityGroup"));
            services.AddHttpClient<ICrudRepository<PurposeOfReferralForTreatment>, WebRepository<PurposeOfReferralForTreatment>>(
                 (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/PurposeOfReferralForTreatment"));
            services.AddHttpClient<ICrudRepository<WhoSentToHospital>, WebRepository<WhoSentToHospital>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/WhoSentToHospital"));
        }
    }
}

