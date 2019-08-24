using System.Collections.Generic;
using GoogleProject.Pages.Main;
using OpenQA.Selenium;

namespace GoogleProject.Pages.SearchPages
{
    public class SearchPage : MainPage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        protected IList<IWebElement> LowBarElements => _driver.FindElements(By.XPath("//div[@id='hdtb-msb-vis']/div"));

        protected List<SearchResult> Links => InitializeListSearchResult(_driver.FindElements(By.XPath("//div[@class='g']")));
    

        public List<SearchResult> InitializeListSearchResult(IReadOnlyCollection<IWebElement> elements)
        {
            List<SearchResult> list = new List<SearchResult>();

            foreach (var current in elements)
            {
                list.Add(new SearchResult(current));
            }
            return list;
        }

        public List<SearchResult> GetListSearchResult()
        {
            return Links;
        }

        public SearchResult FindAppropriateLink(string product)
        {

            foreach (var item in Links)
            {
                if (item.IsAppropriate(product))
                {
                    return item;
                }
            }
            return null;
        }

        public string GetTitleTextLink(string name)
        {
            return FindAppropriateLink(name).GetTextLink();
        }
    }
}
