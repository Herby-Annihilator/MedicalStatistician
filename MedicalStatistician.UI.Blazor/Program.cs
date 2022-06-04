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
           // builder.RootComponents.Add<HeadOutlet>("head::after");

            var services = builder.Services;
            services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


            services.AddHttpClient<ICrudRepository<Sex>, WebRepository<Sex>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/Sex"));
            services.AddHttpClient<ICrudRepository<DisabilityGroup>, WebRepository<DisabilityGroup>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/DisabilityGroup"));
           /* services.AddHttpClient<ICrudRepository<NamedEntity>, WebRepository<NamedEntity>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/PurposeOfReferralForTreatment"));
            services.AddHttpClient<ICrudRepository<NamedEntity>, WebRepository<NamedEntity>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/WhoSentToHospital"));*/
            

            await builder.Build().RunAsync();
        }
    }
}

/*services.AddHttpClient<ICrudRepository<NamedEntity>, WebRepository<NamedEntity>>(
    (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/DisabilityGroup"));
services.AddHttpClient<ICrudRepository<NamedEntity>, WebRepository<NamedEntity>>(
    (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/PurposeOfReferralForTreatment"));
services.AddHttpClient<ICrudRepository<NamedEntity>, WebRepository<NamedEntity>>(
    (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/WhoSentToHospital"));*/
//var http = new HttpClient()
//{
//    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
//};

//builder.Services.AddScoped(sp => http);

//var response = await http.GetAsync("appsettings.json");
//var stream = await response.Content.ReadAsStreamAsync();

//builder.Configuration.AddJsonStream(stream);

////
//builder.Services.AddDbContext<MedicalStatisticianDbContext>(
//    opt => opt
//    .UseNpgsql(
//        builder.Configuration.GetConnectionString("Postgres"),
//        b => b.MigrationsAssembly("MedicalStatistician.DAL.Postrgres"))
//);

//services.AddScoped(typeof(ICrudRepository<>), typeof(DefaultCrudRepository<>));

