using Ionic.Zip;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Linq;

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

        /// <summary>
        /// Searches if the pointed Zip file contains file with given name
        /// </summary>
        /// <param name="zipFilePath">full path to the zip archive.</param>
        /// <param name="nameOfSearchedFile">searched file name.</param>
        /// <returns>true if the file was found in the archive or false if didn't.</returns>
        public static bool CheckIfZipFileContainsAnotherFile(string zipFilePath, string nameOfSearchedFile)
        {
            var zipFile = ZipFile.Read(zipFilePath);
            var result = zipFile.Any(x => x.FileName.EndsWith(nameOfSearchedFile));
            return result;
        }
    }
}
