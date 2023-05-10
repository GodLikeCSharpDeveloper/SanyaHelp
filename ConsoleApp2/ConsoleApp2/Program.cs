using ConsoleApp2;
using Microsoft.Extensions.DependencyInjection;

namespace MyNamespace;

class class1
{
    private static IServiceCollection ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();
        // IMPORTANT! Register our application entry point
        services.AddTransient<ConsoleApplication>();
        return services;
    }
    public static void Main(string[] args)
    {
        var services = ConfigureServices();
        var serviceProvider = services.BuildServiceProvider();
        serviceProvider.GetService<ConsoleApplication>().Run();

    }
}
