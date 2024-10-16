using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jcfvsouz.Packages.Application.Configuration
{
    public static class ConfigurationExtensions
    {
        public static IConfiguration AddConfiguration(this IServiceCollection serviceCollection,
            string jsonFile = "appsettings.json")
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .AddJsonFile(jsonFile, optional: false, reloadOnChange: true)
            .Build();

            serviceCollection.AddScoped((_) => configuration);

            return configuration;
        }
    }
}