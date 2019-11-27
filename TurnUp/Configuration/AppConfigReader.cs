using System;
using System.Configuration;
using TurnUp.Interface;
using TurnUp.Settings;

namespace TurnUp.Configuration
{
    public class AppConfigReader: IConfig
    {
        public BrowserType GetBrowser()
        {
            Console.WriteLine("Broswer Key: "+AppConfigKeys.browser);
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);

        }

        public string GetWebsiteUrl()
        {
            string url = ConfigurationManager.AppSettings.Get(AppConfigKeys.website);
            return url;
        }
    }
}
