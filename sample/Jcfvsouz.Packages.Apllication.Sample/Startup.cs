using Jcfvsouz.Packages.Application.Builder;
using Jcfvsouz.Packages.Application.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jcfvsouz.Packages.Apllication.Sample
{
    public class Startup : IStartup
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddConfiguration();
        }
    }
}