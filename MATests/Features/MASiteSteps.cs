using BoDi;
using MATests.PageObjects;
using MATests.PageObjects.Contact;
using MATests.PageObjects.MediaPack;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace MATests.Features
{
    [Binding]
    public class MASiteSteps
    {
        private IWebDriver _driver;
        private IObjectContainer _objectContainer;
        private string _fileDownloadsPath;
        private MainPage _mainPage;
        private ContactPage _contactPage;
        private MediaPackPage _mediaPackPage;


        public MASiteSteps(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            _driver = _objectContainer.Resolve<IWebDriver>();
            _fileDownloadsPath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\Downloads";
        }

        [Given(@"I am on the Main page")]
        public void GivenIAmOnTheMainPage()
        {
            _mainPage = new MainPage(_driver);
            _mainPage.GoTo();
        }
        
        [When(@"I go to Contact Page")]
        public void WhenIGoToContactPage()
        {
            _contactPage = _mainPage.GetMainMenu().OpenContactPage();
        }
        
        [When(@"I go to Media Pack page")]
        public void WhenIGoToMediaPackPage()
        {
            _mediaPackPage = _contactPage.ClickMediaPackIcon();
        }
        
        [When(@"I download Logotypy")]
        public void WhenIDownloadLogotypy()
        {
            _mediaPackPage.DownloadLogotypes();
        }
        
        [When(@"I search '(.*)'")]
        public void WhenISearch(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the file '(.*)' is dowloaded")]
        public void ThenTheFileIsDowloaded(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"file '(.*)' contains file '(.*)'")]
        public void ThenFileContainsFile(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Contact button changes color when mouse get's over it")]
        public void ThenContactButtonChangesColorWhenMouseGetSOverIt()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the websie is loaded correclty")]
        public void ThenTheWebsieIsLoadedCorreclty()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"page contains '(.*)' results")]
        public void ThenPageContainsResults(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"results are on the '(.*)' pages")]
        public void ThenResultsAreOnThePages(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
