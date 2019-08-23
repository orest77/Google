using System;
using GoogleProject.Pages.Main;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace GoogleProject.Pages

{
    public class Application
    {
        protected readonly IWebDriver Driver;

        public Application(BrowserType driverType = BrowserType.Chrome)
        {
            switch (driverType)
            {
                case BrowserType.Chrome:
                    var chromeOptions= new ChromeOptions();
                    chromeOptions.AddArguments("--start-maximized");
                    Driver = new ChromeDriver(Environment.CurrentDirectory, chromeOptions);
                    break;
                case BrowserType.IE:
                    var internetExplorerOptions = new InternetExplorerOptions()
                    {
                    IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                    EnsureCleanSession = true,
                    IgnoreZoomLevel = true
                    };
                    Driver = new InternetExplorerDriver(internetExplorerOptions);
                    break;
                default:
                    throw new Exception("No browser type");
            }

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public MainPage OpenApplication(string url = "https://www.google.com")
        {
            
            Driver.Navigate().GoToUrl(url);
            return new MainPage(Driver);
        }

        public Application CloseApplication()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Quit();
            return this;
        }
    }
}
