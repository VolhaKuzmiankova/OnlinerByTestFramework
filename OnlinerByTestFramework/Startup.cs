using DotNetEnv;
using Microsoft.Extensions.Configuration;
using OnlinerByTestFramework.Configurations;

namespace OnlinerByTestFramework
{
    public class Startup
    {
        private readonly AppSettings _appSettings = new AppSettings();

        public static AppSettings AppSettings { get; set; }

        public Startup()
        {
            Env.Load();
            Env.TraversePath().Load();

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            configuration.Bind(_appSettings);
            AppSettings = _appSettings;
        }
    }
}
