using Lister.Configuration;
using Microsoft.Extensions.Configuration;

namespace Lister
{
    internal static class Program
    {
        public static AppSetting AppSettings;
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
            AppSettings = configuration.GetSection(AppSetting.SectionName).Get<AppSetting>();
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}