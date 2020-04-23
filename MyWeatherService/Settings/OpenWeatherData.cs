using System.Security;

namespace MyWeatherService.Settings
{
    public class OpenWeatherData
    {
        public SecureString ApiKey { get; internal set; }
        public string DefaultName { get; internal set; }
    }
}
