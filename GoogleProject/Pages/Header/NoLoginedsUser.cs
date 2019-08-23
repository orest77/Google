using OpenQA.Selenium;

namespace GoogleProject.Pages.Header
{
    public interface ISingInPage
    {
    }

    public class NoLoginedsUser : TopBar, ISingInPage
    {
        protected IWebElement LoginButton => Driver.FindElement(By.ClassName("#gb_70"));

        public NoLoginedsUser(IWebDriver driver) : base(driver)
        {
        }

        public ISingInPage ClickLoginButton()
        {
            LoginButton.Click();
            return this;
        }

    }
}
