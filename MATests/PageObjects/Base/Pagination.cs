using OpenQA.Selenium;
using System.Collections.Generic;

namespace MATests.PageObjects.Base
{
    public class Pagination : AbstractBase
    {
        public Pagination(IWebDriver driver) : base(driver)
        { }

        private IWebElement _previousPagButtone => _driver.FindElement(By.CssSelector(".prev"));
        private IWebElement _nextPageButton => _driver.FindElement(By.CssSelector(".prev"));
        private IReadOnlyCollection<IWebElement> _pages => _driver.FindElements(By.CssSelector(".pagination li"));

        public int GetNumberOfPages() => _pages.Count - 2; // -2 because prev and next button are included.

        public void GoToPreviousPage()
        {
            _previousPagButtone.Click();
        }
        public void GoToNextPage()
        {
            _nextPageButton.Click();
        }

    }
}
