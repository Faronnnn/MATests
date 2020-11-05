﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MATests.PageObjects.Base
{
    public class PageWithPagination : AbstractPage
    {
        public PageWithPagination(IWebDriver driver) : base(driver)
        { }

        public Pagination Pagination()
        {
            return new Pagination(_driver);
        }
    }
}
