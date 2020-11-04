using System;
using TechTalk.SpecFlow;

namespace MATests.Features
{
    [Binding]
    public class MASiteSteps
    {
        [Given(@"I am on the Main page")]
        public void GivenIAmOnTheMainPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I go to Contact Page")]
        public void WhenIGoToContactPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I go to Media Pack page")]
        public void WhenIGoToMediaPackPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I download Logotypy")]
        public void WhenIDownloadLogotypy()
        {
            ScenarioContext.Current.Pending();
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
