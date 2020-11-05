using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MATests.PageObjects.Base
{
    public class AbstractPage : AbstractBase
    {
        private string _MADomain = "https://www.omada.net";

        protected string _address;

        

        public AbstractPage(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Go directly to this page.
        /// </summary>
        public virtual void GoTo()
        {
            _driver.Navigate().GoToUrl(_MADomain + _address);
        }

        public class MainMenu : AbstractBase
        {
            internal MainMenu(IWebDriver driver) : base(driver)
            { }

            private IWebElement _aboutButton => _driver.FindElement(By.CssSelector("a[class='mega-menu-link'][href='https://www.medicalgorithmics.pl/o-nas']"));
            private IWebElement _productsButton => _driver.FindElement(By.CssSelector("a[class='mega-menu-link'][href='https://www.medicalgorithmics.pl/produkty']"));
            private IWebElement _investorsButton => _driver.FindElement(By.CssSelector("a[class='mega-menu-link'][href='https://www.medicalgorithmics.pl/inwestorzy']"));
            private IWebElement _contactButton => _driver.FindElement(By.CssSelector("a[class='mega-menu-link'][href='https://www.medicalgorithmics.pl/kontakt']"));

            public void OpenAboutSubmenu()
            {
                _aboutButton.Click();
            }

            public void OpenProductsSubmenu()
            {
                _productsButton.Click();
            }

            public void OpenInvestorsSubmenu()
            {
                _investorsButton.Click();
            }

            public void OpenContactPage()
            {
                _contactButton.Click();
            }
        }
    }
}
