using OpenQA.Selenium;

namespace GoogleProject.Pages.Header
{
    public class LoginedUser : TopBar
    {
        protected IWebElement AccountButton => Driver.FindElement(By.XPath("(//div[@class='gb_Va']/..)[2]"));

        public LoginedUser(IWebDriver driver) : base(driver)
        {
        }

        public void ClickAccountButton()
        {
            AccountButton.Click();
        }
    }
}
