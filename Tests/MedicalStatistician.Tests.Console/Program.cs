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
        services.AddHttpClient<ICrudRepository<MKB10>, WebRepository<MKB10>>(
            client =>
            {
                client.BaseAddress = new Uri($"{hostBuilderContext.Configuration["WebApi"]}/api/Mkb10/");
            });
    }
    public static async Task Main()
    {
        using var host = Hosting;
        await host.StartAsync();

        ICrudRepository<MKB10> repository = Services.GetRequiredService<ICrudRepository<MKB10>>();
        IEnumerable<MKB10> collection = await repository.GetAsync(10, 8);
        foreach (var item in collection)
        {
            Console.WriteLine(item.MkbName);
        }
        Console.Read();
        //Console.WriteLine("Создание файла excel...");
        //Report36pl report = new Report36pl();
        //report.Export("", new ExcelExporter());
        //Console.WriteLine("Файл создан");
        Console.Read();
        await host.StopAsync();
    }
}