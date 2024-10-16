using Jcfvsouz.Packages.Application.Builder;

namespace Jcfvsouz.Packages.Apllication.Sample
{
    internal class Program
    {
        static SampleApplication? Application { get; set; }
        static void Main(string[] args)
        {
            Application ??= new ApplicationBuilder<SampleApplication>()
                .WithStartup<Startup>()
                .Build();

            Application.Run();
        }
    }
}
