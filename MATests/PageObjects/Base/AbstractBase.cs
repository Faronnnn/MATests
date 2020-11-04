using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

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
