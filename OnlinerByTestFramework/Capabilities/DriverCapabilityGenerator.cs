using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace OnlinerByTestFramework.Capabilities
{
    public static class DriverCapabilityGenerator
    {
        public static ChromeOptions GetChromeOptions()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.AddArgument("--disable-extensions");
            chromeOptions.AddArgument("--start-maximized");

            chromeOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
            chromeOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);

            return chromeOptions;
        }
        
        public static FirefoxOptions GetFireFoxOptions()
        {
            var firefoxOptions = new FirefoxOptions();
            var firefoxOptionsProfile = new FirefoxProfile();

            firefoxOptionsProfile.SetPreference("browser.download.folderList", 2);
            firefoxOptionsProfile.SetPreference("browser.helperApps.neverAsk.saveToDisk", Constants.ConstantsForFireFox.MimeTypes);
            firefoxOptionsProfile.SetPreference("browser.helperApps.neverAsk.openFile", Constants.ConstantsForFireFox.MimeTypes);
            firefoxOptions.Profile = firefoxOptionsProfile;

            firefoxOptions.SetLoggingPreference(LogType.Browser, LogLevel.All);
            firefoxOptions.SetLoggingPreference(LogType.Driver, LogLevel.All);
            return firefoxOptions;
        }
    }
}