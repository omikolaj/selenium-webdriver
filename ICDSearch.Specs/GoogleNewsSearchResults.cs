using TechTalk.SpecFlow;

namespace ICDSearch.Specs
{
    [Binding]
    public class GoogleNewsSearchResults
    {
        [Given(@"a web browser is on the Google's News tab")]
        public void GivenAWebBrowserIsOnTheGoogleSNewsTab()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the search phrase ""(.*)"" is executed")]
        public void WhenTheSearchPhraseIsExecuted(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the first result for ""(.*)"" should be ICD Press release")]
        public void ThenTheFirstResultForShouldBeICDPressRelease(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
