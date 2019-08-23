using GoogleProject.Pages.SearchPages;
using OpenQA.Selenium;

namespace GoogleProject.Pages.Main
{
    public class MainPage
    {
        private IWebDriver _driver;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        protected IWebElement ImageGoogle => _driver.FindElement(By.XPath("//div[@id='lga']/img"));

        protected IWebElement SearchBox => _driver.FindElement(By.Name("q"));

        protected IWebElement SearchGoogleButton => _driver.FindElement(By.Name("btnK"));

        protected IWebElement FeelingLuckyButton => _driver.FindElement(By.XPath("(//center/input[@name='btnI'])[2]"));

        protected IWebElement ChangeLanguageLink => _driver.FindElement(By.CssSelector("#SIvCob a"));
        
        //Methods for title google image
        public bool IsDisplayedImage()
        {
            return ImageGoogle.Displayed;
        }

        //Methods for Search Box
        public void ClickOnSearchBox()
        {
            SearchBox.Click();
        }

        public void ClearSearchBox()
        {
            SearchBox.Clear();
        }

        public void EnterSearchBox(string someText)
        {
            SearchBox.SendKeys(someText);
        }

        //Methods for Search Google Button
        public string GetTextSearchGoogleButton()
        {
            return SearchGoogleButton.Text;
        }

        public void ClickSearchGoogleButton()
        {
            SearchGoogleButton.Click();
        }

        //Methods for Feeling Lucky Button
        public string GetTextFeelingLuckyButton()
        {
            return SearchGoogleButton.Text;
        }

        public void ClickFeelingLuckyButton()
        {
            SearchGoogleButton.Click();
        }

        // Logic method
        public MainPage ClearClickEnterSearchBox(string someText)
        {
            ClickOnSearchBox();
            ClickOnSearchBox();
            EnterSearchBox(someText);
            return this;
        }

        public SearchPage SetSearchBoxAndClickButton(string someText)
        {
            ClearClickEnterSearchBox(someText);
            ClickSearchGoogleButton();
            return new SearchPage(_driver);
        }

    }
}
