using Microsoft.Extensions.Configuration;
using System.IO;

namespace Agl.Infrastructure.AppConfig
{
    public static class AppConfiguration
    {
        public static readonly string AglWebServiceUrl;

         static AppConfiguration()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            var root = configurationBuilder.Build();
            AglWebServiceUrl = root.GetSection("AglWebServiceUrl").GetSection("Url").Value;
           
        }

       

    }
}
