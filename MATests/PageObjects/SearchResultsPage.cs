﻿using MATests.PageObjects.Base;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace MATests.PageObjects
{
    class SearchResultsPage : PageWithPagination
    {
        public SearchResultsPage(IWebDriver driver) : base(driver)
        { }

        private IReadOnlyCollection<IWebElement> _results => _driver.FindElements(By.CssSelector(".latest_post_custom"));

        public int GetNumberOfResults() => _results.Count;
    }
}
