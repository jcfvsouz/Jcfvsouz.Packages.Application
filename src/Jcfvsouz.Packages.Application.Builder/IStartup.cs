using Microsoft.Extensions.DependencyInjection;

namespace Jcfvsouz.Packages.Application.Builder
{
    public interface IStartup
    {
        public void ConfigureServices(IServiceCollection serviceCollection);
    }
}