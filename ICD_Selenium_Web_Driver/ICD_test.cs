using System.Collections.Generic;
using ICD_Selenium_Web_Driver.PageObjects;
using ICD_Selenium_Web_Driver.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ICD_Selenium_Web_Driver
{
    internal class ICD_test
    {

        #region Fields and Properties

        private IWebDriver driver;

        #endregion Fields and Properties

        #region SetUp and TearDown

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();            
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

        #endregion SetUp and TearDown

        #region Tests

        private static IEnumerable<TestCaseData> ICDSearchData
        {
            get
            {
                yield return new TestCaseData(ICDTestData.SearchPortal, "https://icdportal.com/", ICDTestData.Google).SetName($"Test Case for {ICDTestData.Google} using {ICDTestData.SearchPortal}");
                yield return new TestCaseData(ICDTestData.SearchICDFull, "https://icdportal.com/", ICDTestData.Google).SetName($"Test Case for {ICDTestData.Google} using {ICDTestData.SearchICDFull}");                
            }
        }

        [Test, ICD(ICDTestType.SmokeTest)]        
        [TestCaseSource(nameof(ICDSearchData))]
        public void VerifyICDPortalIsFirstSearchResultGoogle(string searchCriteria, string expectedURL, string searchEngine)
        {            
            GoogleHomePage search = new GoogleHomePage(driver);
            search.GoToPage(searchEngine);
            GoogleResultPage results = search.Criteria(searchCriteria).Search();            
            results.NavigateTo(results.FirstResult);            
            
            Assert.That(driver.Url, Is.EqualTo(expectedURL), "The first returned website URL did not match the expected website URL");
        }

        private static IEnumerable<TestCaseData> BingICDSearchData
        {
            get
            {
                yield return new TestCaseData(ICDTestData.SearchPortal, "https://icdportal.com/", ICDTestData.Bing).SetName($"Test Case for {ICDTestData.Bing} using {ICDTestData.SearchPortal}");
                yield return new TestCaseData(ICDTestData.SearchICDFull, "https://icdportal.com/", ICDTestData.Bing).SetName($"Test Case for {ICDTestData.Bing} using {ICDTestData.SearchICDFull}");
            }
        }

        [Test, ICD(ICDTestType.SmokeTest)]
        [TestCaseSource(nameof(BingICDSearchData))]
        public void VerifyICDPortalIsFirstSearchResultBing(string searchCriteria, string expectedURL, string searchEngine)
        {
            BingHomePage search = new BingHomePage(driver);
            search.GoToPage(searchEngine);
            BingResultPage results = search.Criteria(searchCriteria).Search();
            results.NavigateTo(results.FirstResult);

            Assert.That(driver.Url, Is.EqualTo(expectedURL), "The first returned website URL did not match the expected website URL");
        }

        private static IEnumerable<TestCaseData> ICDPortalLoginTests
        {
            get
            {
                yield return new TestCaseData(ICDTestData.UnregisteredUsername, ICDTestData.UnregisteredPassword).SetName($"Test Case for {nameof(ICDTestData.UnregisteredUsername)} and {nameof(ICDTestData.UnregisteredPassword)}");
                yield return new TestCaseData(ICDTestData.BlankUsername, ICDTestData.BlankPassword).SetName($"Test Case for {nameof(ICDTestData.BlankUsername)} and {nameof(ICDTestData.BlankPassword)}");
                yield return new TestCaseData(ICDTestData.UnicodeUsername, ICDTestData.UnicodePassword).SetName($"Test Case for {nameof(ICDTestData.UnicodeUsername)} and {nameof(ICDTestData.UnicodePassword)}");
                yield return new TestCaseData(ICDTestData.SQLInjectionUsername, ICDTestData.SQLInjectionPassword).SetName($"Test Case for {nameof(ICDTestData.SQLInjectionUsername)} and {nameof(ICDTestData.SQLInjectionPassword)}");
            }
        }

        [Test, ICD(ICDTestType.SmokeTest)]
        [TestCaseSource(nameof(ICDPortalLoginTests))]
        public void VerifyICDPortalDoesNotAcceptInvalidCredentials(string username, string password)
        {
            ICDPortalLogin homePage = new ICDPortalLogin(driver);
            driver.Navigate().GoToUrl("https://icdportal.com/2gP");
            homePage.Username.SendKeys(username);
            homePage.Password.SendKeys(password);
            homePage.Login();

            bool errorMessageDisplayed = homePage.IsErrorMessageDisplayed;

            Assert.That(errorMessageDisplayed, Is.True, "The error message was not found");

        }

        #endregion Tests

    }
}
