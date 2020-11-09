using MATests.PageObjects.Base;
using OpenQA.Selenium;

namespace MATests.PageObjects
{
    class MainPage : AbstractPage
    {
        public MainPage(IWebDriver driver) : base(driver)
        { }

        private IWebElement _cookiesAcceptButton => _driver.FindElement(By.CssSelector(".cn-set-cookie.cn-button.bootstrap.cookie-button"));
        private IWebElement _searchPanelButton => _driver.FindElement(By.CssSelector(".search_button.search_slides_from_header_bottom.normal"));
        private IWebElement _searchField => _driver.FindElement(By.CssSelector(".qode_search_field"));
        private IWebElement _beginSearchButton => _driver.FindElement(By.CssSelector(".qode_search_submit"));

        public override void GoTo()
        {
            base.GoTo();
            _cookiesAcceptButton.Click();  // closing cokies info so it won't intefere with interacting with other elements.
        }

        public void ToggleSearchPanel()
        {
            _searchPanelButton.Click();
        }

        public void SearchText(string text)
        {
            _searchField.SendKeys(text);
        }

        public SearchResultsPage BeginSearch()
        {
            _beginSearchButton.Click();
            return new SearchResultsPage(_driver);
        }
    }
}
