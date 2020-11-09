using OpenQA.Selenium;

namespace MATests.PageObjects.Base
{
    public class AbstractBase
    {
        protected IWebDriver _driver;

        public AbstractBase(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
