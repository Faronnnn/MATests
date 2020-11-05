using MATests.PageObjects.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MATests.PageObjects
{
    class SearchResults : PageWithPagination
    {
        public SearchResults(IWebDriver driver) : base(driver)
        { }

        private IReadOnlyCollection<IWebElement> _results => _driver.FindElements(By.CssSelector("latest_post_custom"));

        public int GetNumberOfResults() => _results.Count;
    }
}
