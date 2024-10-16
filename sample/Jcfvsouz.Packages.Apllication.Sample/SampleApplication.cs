using Microsoft.Extensions.Configuration;

namespace Jcfvsouz.Packages.Apllication.Sample
{
    public class SampleApplication(IConfiguration configuration)
    {
        public void Run()
        {
            var userMessage = $"Welcome to {configuration["applicationName"]}";
            Console.WriteLine(userMessage);
        }
    }
}