using MATests.PageObjects.Base;
using MATests.PageObjects.MediaPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace MATests.PageObjects.Contact
{
    public class ContactPage : AbstractPage
    {
        public ContactPage(IWebDriver driver) : base(driver)
        {
            _address = "/kontakt";
        }

        private IWebElement _mediaPackButton => _driver.FindElement(By.CssSelector("a[href='https://www.medicalgorithmics.pl/media-pack']"));

        /// <summary>
        /// Opens Media Pack page and returns new object of this page.
        /// </summary>
        /// <returns></returns>
        public MediaPackPage ClickMediaPackIcon()
        {
            if (_driver is ChromeDriver) // Firefox doesn't need nor support scrolling.
            {
                Actions actions = new Actions(_driver);
                actions.MoveToElement(_mediaPackButton).Perform();
                actions.MoveToElement(_mediaPackButton).Perform(); // After first scroll page likes to go back up.
            }

            _mediaPackButton.Click();
            return new MediaPackPage(_driver);
        }
    }
}
