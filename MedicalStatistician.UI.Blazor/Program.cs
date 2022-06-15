using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Entities.Base;
using MedicalStatistician.DAL.Entities.DbContexts;
using MedicalStatistician.DAL.Repositories.Base;
using MedicalStatistician.DAL.Repositories.EfCore;
using MedicalStatistician.UI.Blazor;
using MedicalStatistician.WebApiClients.Repositories;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Security.Claims;

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

            services.AddOidcAuthentication(options =>
            {
                options.ProviderOptions.Authority = "http://localhost:10000";
                options.ProviderOptions.ClientId = "client_blazor";
                options.ProviderOptions.DefaultScopes.Add("profile");
                options.ProviderOptions.DefaultScopes.Add("email");
                options.ProviderOptions.DefaultScopes.Add("openid");
                options.ProviderOptions.ResponseType = "code";
            });

            services.AddOptions();
            services.AddAuthorizationCore();

            services.AddScoped<AuthenticationStateProvider, TokenAuthenticationStateProvider>();
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
            services.AddHttpClient<ICrudRepository<SourceOfLivelihood>, WebRepository<SourceOfLivelihood>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/SourceOfLivelihood"));
            services.AddHttpClient<ICrudRepository<DiseaseOutcome>, WebRepository<DiseaseOutcome>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/DiseaseOutcome"));
            services.AddHttpClient<ICrudRepository<CauseOfDeath>, WebRepository<CauseOfDeath>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/CauseOfDeath"));
            services.AddHttpClient<ICrudRepository<Education>, WebRepository<Education>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/Education"));
            services.AddHttpClient<ICrudRepository<ResidenceStatus>, WebRepository<ResidenceStatus>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/ResidenceStatus"));
            services.AddHttpClient<ICrudRepository<TypeOfForcedTreatment>, WebRepository<TypeOfForcedTreatment>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/TypeOfForcedTreatment"));
            services.AddHttpClient<ICrudRepository<PlaceOfDeparture>, WebRepository<PlaceOfDeparture>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/PlaceOfDeparture"));
            services.AddHttpClient<ICrudRepository<TypeOfOutpatientCare>, WebRepository<TypeOfOutpatientCare>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/TypeOfOutpatientCare"));
            services.AddHttpClient<ICrudRepository<OrderOfAdmission>, WebRepository<OrderOfAdmission>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/OrderOfAdmission"));
            services.AddHttpClient<ICrudRepository<StatusOfJudgesDecisionUnderArticle35>, WebRepository<StatusOfJudgesDecisionUnderArticle35>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/StatusOfJudgesDecisionUnderArticle35"));
            services.AddHttpClient<ICrudRepository<TypeOfJudgment>, WebRepository<TypeOfJudgment>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/TypeOfJudgment"));
            services.AddHttpClient<ICrudRepository<PatientEntryRoutes>, WebRepository<PatientEntryRoutes>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/PatientEntryRoutes"));
            services.AddHttpClient<ICrudRepository<Accommodations>, WebRepository<Accommodations>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/Accommodations"));
            services.AddHttpClient<ICrudRepository<SourcesOfPaymentForMedicalCare>, WebRepository<SourcesOfPaymentForMedicalCare>>(
                (host, client) => client.BaseAddress = new(host.GetRequiredService<IWebAssemblyHostEnvironment>().BaseAddress + "api/SourcesOfPaymentForMedicalCare"));

        }
    }

    public class TokenAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var anonymousIdentity = new ClaimsIdentity();
            var anonymousPrincipal = new ClaimsPrincipal(anonymousIdentity);
            return new AuthenticationState(anonymousPrincipal);
        }
    }
}

