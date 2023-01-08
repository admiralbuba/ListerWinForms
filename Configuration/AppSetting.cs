namespace Lister.Configuration
{
    public class AppSetting
    {
        public static string SectionName = "AppSettings";
        public string BaseUrl { get; set; }
        public string HubEndpoint { get; set; }
        public string AuthEndpoint { get; set; }
    }
}