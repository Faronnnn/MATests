using MATests.PageObjects.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MATests.PageObjects
{
    class MainPage : AbstractPage
    {
        public MainPage(IWebDriver driver) : base(driver)
        {  }

        private IWebElement _searchPanelButton => _driver.FindElement(By.CssSelector(".search_button.search_slides_from_header_bottom.normal"));
        private IWebElement _searchField => _driver.FindElement(By.CssSelector(".qode_search_field"));
        private IWebElement _beginSearchButton => _driver.FindElement(By.CssSelector(".qode_search_submit"));

        public void ToggleSearchPanel()
        {
            _searchPanelButton.Click();
        }

        public void SearchText(string text)
        {
            _searchField.SendKeys(text);
        }

        public void BeginSearch()
        {
            _beginSearchButton.Click();
        }
    }
}
