using MedicalStatistician.DAL.Entities.Base;
using MedicalStatistician.DAL.Entities.DbContexts;
using MedicalStatistician.DAL.Repositories.Base;
using MedicalStatistician.DAL.Repositories.EfCore;
using MedicalStatistician.UI.Blazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var services = builder.Services;
services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

////
builder.Services.AddDbContext<MedicalStatisticianDbContext>(
    opt => opt
    .UseNpgsql(
        builder.Configuration.GetConnectionString("Postgres"),
        b => b.MigrationsAssembly("MedicalStatistician.DAL.Postrgres"))
);

services.AddScoped(typeof(ICrudRepository<>), typeof(DefaultCrudRepository<>));

await builder.Build().RunAsync();
