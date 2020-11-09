using BoDi;
using FluentAssertions;
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
        private SearchResultsPage _searchResultsPage;


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
        public void WhenISearch(string phrase)
        {
            _mainPage.ToggleSearchPanel();
            _mainPage.SearchText(phrase);
            _searchResultsPage = _mainPage.BeginSearch();
        }
        
        [Then(@"the file '(.*)' is dowloaded")]
        public void ThenTheFileIsDowloaded(string fileName)
        {
            Helpers.Helpers.CheckIfFileExist(_driver, _fileDownloadsPath, fileName).Should().BeTrue();
        }
        
        [Then(@"file '(.*)' contains file '(.*)'")]
        public void ThenFileContainsFile(string archiveFileName, string fileName)
        {
            string path = _fileDownloadsPath + "\\" +  archiveFileName;
            Helpers.Helpers.CheckIfZipFileContainsAnotherFile(path, fileName).Should().BeTrue();
        }
        
        [Then(@"Contact button changes color when mouse get's over it")]
        public void ThenContactButtonChangesColorWhenMouseGetSOverIt()
        {
            _contactPage.GetMainMenu().MoveCursorOverContactButton();
            // TODO: Checking if color of Contact button has changed .
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"the websie is loaded correclty")]
        public void ThenTheWebsieIsLoadedCorreclty()
        {
            _searchResultsPage.IsPageLoadedCorrectly().Should().BeTrue();
        }
        
        [Then(@"page contains '(.*)' results")]
        public void ThenPageContainsResults(int numberOfResults)
        {
            _searchResultsPage.GetNumberOfResults().Should().Be(numberOfResults); // need to check this.
        }
        
        [Then(@"results are on the '(.*)' pages")]
        public void ThenResultsAreOnThePages(int amountOfPages)
        {
            _searchResultsPage.Pagination().GetNumberOfPages().Should().Be(amountOfPages);
        }
    }
}
