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
        services.AddHttpClient<ICrudRepository<Sex>, WebRepository<Sex>>(
            client =>
            {
                client.BaseAddress = new Uri($"{hostBuilderContext.Configuration["WebApi"]}/api/Sex/");
            });
    }
    public static async Task Main()
    {
        using var host = Hosting;
        await host.StartAsync();

        //ICrudRepository<Sex> repository = Services.GetRequiredService<ICrudRepository<Sex>>();
        //IEnumerable<Sex> collection = await repository.GetAllAsync();
        //Console.WriteLine("Перед обновлением:");
        //foreach (var item in collection)
        //{
        //    Console.WriteLine(item.Name);
        //}
        //Console.WriteLine("Изменение мужского на средний. Результат:");
        //var entity = collection.FirstOrDefault(s => s.Name.ToLower() == "мужской");
        //entity.Name = "средний";
        //Console.WriteLine("После изменения локально:");
        //foreach (var item in collection)
        //{
        //    Console.WriteLine(item.Name);
        //}
        //Console.WriteLine("Вызов метода Update и получение данных:");
        //await repository.UpdateAsync(entity);
        //collection = await repository.GetAllAsync();
        //foreach (var item in collection)
        //{
        //    Console.WriteLine(item.Name);
        //}
        TestDates();
        Console.Read();
        //Console.WriteLine("Создание файла excel...");
        //Report36pl report = new Report36pl();
        //report.Export("", new ExcelExporter());
        //Console.WriteLine("Файл создан");
        Console.Read();
        await host.StopAsync();
    }

    private static void TestDates()
    {
        DateTime start = DateTime.Now;
        DateTime end = new DateTime(2022, 6, 16, 15, 15, 15);
        Console.WriteLine($"start = {start}; end = {end}");
        Console.WriteLine("Converting...");
        start = new DateTime(start.Year, start.Month, start.Day);
        end = new DateTime(end.Year, end.Month, end.Day);
        var result = end - start;
        Console.WriteLine($"start = {start}; end = {end}");
        Console.WriteLine($"result = end - start = {end} - {start} = {result.Days}");
        DateTime test1 = new DateTime(2023, 1, 1);
        DateTime test2 = new DateTime(2022, 12, 31);
        Console.WriteLine($"test1 = {test1}, test2 = {test2}");
        Console.WriteLine($"test1 - test2 = {test1} - {test2} = {(test1 - test2).Days}");
        test2 = new DateTime(test1.Year, test1.Month, test1.Day);
        if (test1 == test2) Console.WriteLine($"test1 = test2: {test1} = {test2}");
        Console.WriteLine($"test1 - test2 = {test1} - {test2} = {(test1 - test2).Days}");
    }
}