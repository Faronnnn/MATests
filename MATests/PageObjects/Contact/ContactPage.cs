using MATests.PageObjects.Base;
using MATests.PageObjects.MediaPack;
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

        private IWebElement _mediaPackButton => _driver.FindElement(By.CssSelector("a[href='https://www.medicalgorithmics.pl/media-pack/']"));

        public MediaPackPage ClickMediaPackIcon()
        {
            _mediaPackButton.Click();
            return new MediaPackPage(_driver);
        }
    }
}
