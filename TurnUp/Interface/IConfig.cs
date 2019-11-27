using System;
using TurnUp.Configuration;

namespace TurnUp.Interface
{
    public interface IConfig
    {
        BrowserType GetBrowser();

        string GetWebsiteUrl();
    }
}
