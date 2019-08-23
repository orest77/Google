using OpenQA.Selenium;

namespace GoogleProject.Pages.Header
{
    public  abstract class TopBar
    {
        protected readonly IWebDriver Driver;

        protected IWebElement GmailButton => Driver.FindElement(By.XPath("(//a[@data-pid='23'])[1]"));

        protected IWebElement ImagesButton => Driver.FindElement(By.XPath("(//a[@data-pid='2'])[1]"));

        protected IWebElement AppButton => Driver.FindElement(By.CssSelector(".gb_Kf"));

        public TopBar(IWebDriver driver)
        {
            Driver = driver;
        }

    }
}
