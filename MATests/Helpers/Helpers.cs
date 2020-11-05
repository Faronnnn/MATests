using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MATests.Helpers
{
    class Helpers
    {
        public static bool CheckIfFileExist(IWebDriver driver, string downloadsPath, string fileName)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                wait.Until<bool>(x => File.Exists($"{downloadsPath}/{fileName}"));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
