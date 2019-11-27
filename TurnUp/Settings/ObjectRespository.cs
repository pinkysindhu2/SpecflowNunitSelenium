using System;
using OpenQA.Selenium;
using TurnUp.Interface;
using NUnit.Framework;

namespace TurnUp.Settings
{
    public class ObjectRespository
    {
        public static IConfig config { get; set; }
        
        public static IWebDriver driver { get; set; }
    }
}
