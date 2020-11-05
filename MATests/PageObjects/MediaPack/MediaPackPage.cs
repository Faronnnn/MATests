using MATests.PageObjects.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MATests.PageObjects.MediaPack
{
    public class MediaPackPage : AbstractPage
    {
        public MediaPackPage(IWebDriver driver) : base(driver)
        {
            _address = "/media-pack";
        }

        private IWebElement _logotypesButton => _driver.FindElement(By.CssSelector("a[href='https://www.medicalgorithmics.pl/wp-content/uploads/2018/10/logotypy.zip']"));

        public void DownloadLogotypes()
        {
            _logotypesButton.Click();
        }
    }
}
