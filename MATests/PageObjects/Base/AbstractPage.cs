using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MATests.PageObjects.Base
{
    class AbstractPage : AbstractBase
    {
        private string _MADomain = "https://www.omada.net";

        protected string _address;

        private IWebElement _aboutButton => _driver.FindElement(By.CssSelector("a[class='mega-menu-link'][href='https://www.medicalgorithmics.pl/o-nas']"));
        private IWebElement _productsButton => _driver.FindElement(By.CssSelector("a[class='mega-menu-link'][href='https://www.medicalgorithmics.pl/produkty']"));
        private IWebElement _investorsButton => _driver.FindElement(By.CssSelector("a[class='mega-menu-link'][href='https://www.medicalgorithmics.pl/inwestorzy']"));
        private IWebElement _contactButton => _driver.FindElement(By.CssSelector("a[class='mega-menu-link'][href='https://www.medicalgorithmics.pl/kontakt']"));

        public AbstractPage(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Go directly to this page.
        /// </summary>
        public virtual void GoTo()
        {
            _driver.Navigate().GoToUrl(_MADomain + _address);
        }
    }
}
