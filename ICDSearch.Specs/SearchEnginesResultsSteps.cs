﻿using ICD_Selenium_Web_Driver.PageObjects;
using ICD_Selenium_Web_Driver.TestData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ICDSearch.Specs
{
    [Binding]
    public class SearchEnginesResultsSteps
    {
        #region Fields and Properties

        private IWebDriver _driver;
        private GoogleHomePage _googleSearchEngine;
        private GoogleResultPage _googleResultPage;
        private BingHomePage _bingSearchEngine;
        private BingResultPage _bingResultPage;

        #endregion Fields and Properties

        #region SetUp and TearDown

        [BeforeScenario("SearchEngine")]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [AfterScenario("SearchEngine")]
        public void TearDown()
        {
            _driver.Close();
        }

        #endregion SetUp and TearDown

        #region Tests

        [Given(@"a web browser is on the ""(.*)"" page")]
        public void GivenAWebBrowserIsOnThePage(string searchEngine)
        {
            switch (searchEngine)
            {
                case ICDTestData.Google:
                    _googleSearchEngine = new GoogleHomePage(_driver);
                    _googleSearchEngine.GoToPage(searchEngine);
                    break;
                case ICDTestData.Bing:
                    _bingSearchEngine = new BingHomePage(_driver);
                    _bingSearchEngine.GoToPage(searchEngine);
                    break;
                default:
                    break;
            }
        }
        
        [Given(@"a web browser is on the Google's News tab")]
        public void GivenAWebBrowserIsOnTheGoogleSNewsTab()
        {
            
        }
        
        [When(@"""(.*)"" executes the search for ""(.*)""")]
        public void WhenExecutesTheSearchFor(string searchEngine, string searchPhrase)
        {
            switch (searchEngine)
            {
                case ICDTestData.Google:
                    _googleResultPage = _googleSearchEngine.Criteria(searchPhrase).Search();
                    break;
                case ICDTestData.Bing:
                    _bingResultPage = _bingSearchEngine.Criteria(searchPhrase).Search();                    
                    break;
                default:
                    break;
            }
        }
        
        [When(@"the search phrase ""(.*)"" is executed")]
        public void WhenTheSearchPhraseIsExecuted(string searchPhrase)
        {
            
        }
        
        [Then(@"the first ""(.*)"" result for ""(.*)"" should be ""(.*)""")]
        public void ThenTheFirstResultForShouldBe(string searchEngine, string searchPhrase, string expectedResult)
        {            
            switch (searchEngine)
            {
                case ICDTestData.Google:
                    _googleResultPage.NavigateTo(_googleResultPage.FirstATagResult);
                    break;
                case ICDTestData.Bing:
                    _bingResultPage.NavigateTo(_bingResultPage.FirstATagResult);
                    break;
                default:
                    break;
            }

            Assert.AreEqual(_driver.Url, (expectedResult), "The first returned website URL did not match the expected website URL");
        }
        
        [Then(@"the first result for ""(.*)"" should be ICD Press release")]
        public void ThenTheFirstResultForShouldBeICDPressRelease(string searchPhrase)
        {
            
        }

        #endregion Tests
    }
}
