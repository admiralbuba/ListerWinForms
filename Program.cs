using Lister.Configuration;
using Microsoft.Extensions.Configuration;

namespace Lister
{
    internal static class Program
    {
        public static AppSettings AppSettings;
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            AppSettings = configuration.GetSection(AppSettings.SectionName).Get<AppSettings>();
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}