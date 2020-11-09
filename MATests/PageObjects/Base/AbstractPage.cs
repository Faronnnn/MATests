using MATests.PageObjects.Contact;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MATests.PageObjects.Base
{
    public class AbstractPage : AbstractBase
    {
        private string _MADomain = "https://www.medicalgorithmics.pl/";

        protected string _address;

        
        public AbstractPage(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// Go directly to this page.
        /// </summary>
        public virtual void GoTo()
        {
            _driver.Navigate().GoToUrl(_MADomain + _address);
        }

        public bool IsPageLoadedCorrectly()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20.0));
            bool result = false;
            result =  wait.Until(delegate (IWebDriver d)
            {
                return ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete");
            });
            return result;
        }

        public MainMenu GetMainMenu()
        {
            return new MainMenu(_driver);
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

            public ContactPage OpenContactPage()
            {
                _contactButton.Click();
                return new ContactPage(_driver);
            }

            public void MoveCursorOverContactButton()
            {
                Actions actions = new Actions(_driver);
                actions.MoveToElement(_contactButton).Perform();
                Thread.Sleep(5000);
            }
        }
    }
}
