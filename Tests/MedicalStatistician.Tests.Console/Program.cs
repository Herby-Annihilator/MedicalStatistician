// See https://aka.ms/new-console-template for more information

using MedicalStatistician.DAL.Entities;
using MedicalStatistician.DAL.Repositories.Base;
using MedicalStatistician.Reports;
using MedicalStatistician.Reports.Exporters.Excel;
using MedicalStatistician.WebApiClients.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

public class Program
{
    private static IHost _hosting;
    public static IHost Hosting => _hosting ??= CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args).ConfigureServices(ConfigureServices);

    public static IServiceProvider Services => Hosting.Services;

    private static void ConfigureServices(HostBuilderContext hostBuilderContext, IServiceCollection services)
    {
        services.AddHttpClient<ICrudRepository<Accommodations>, WebRepository<Accommodations>>(
            client =>
            {
                client.BaseAddress = new Uri($"{hostBuilderContext.Configuration["WebApi"]}/api/Accommodations/");
            });
    }
    public static async Task Main()
    {
        using var host = Hosting;
        await host.StartAsync();

        //ICrudRepository<Accommodations> repository = Services.GetRequiredService<ICrudRepository<Accommodations>>();
        //IEnumerable<Accommodations> collection = await repository.GetAllAsync();
        //foreach (var item in collection)
        //{
        //    Console.WriteLine(item.Name);
        //}
        //Console.Read();
        Console.WriteLine("Создание файла excel...");
        Report36pl report = new Report36pl() { Year = 22 };
        report.Export("", new ExcelExporter());
        Console.WriteLine("Файл создан");
        Console.Read();
        await host.StopAsync();
    }
}