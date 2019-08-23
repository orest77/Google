using OpenQA.Selenium;

namespace GoogleProject.Pages.SearchPages
{
    public class SearchResult
    {
        private IWebElement _current;

        protected IWebElement Link => _current.FindElement(By.ClassName("ellip"));

        public SearchResult(IWebElement current)
        {
            _current = current;
        }

        //Methods 
        public string GetTextLink()
        {
            return Link.Text;
        }

        public void ClickLink()
        {
            Link.Click();
        }

        public bool IsAppropriate(string product)
        {
            return (product.ToLower() == GetTextLink().ToLower());
        }
    }
}
