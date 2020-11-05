using MATests.PageObjects.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MATests.PageObjects.Contact
{
    public class ContactPage : AbstractPage
    {
        public ContactPage(IWebDriver driver) : base(driver)
        {
            _address = "/kontakt";
        }

        private IWebElement _mediaPackButton => _driver.FindElement(By.CssSelector(""));
    }
}
