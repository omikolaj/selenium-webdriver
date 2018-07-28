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
        private IWebDriver driver;
        
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
        public void VerifyICDPortalIsFirstSearchResult(string searchCriteria, string expectedURL, string searchEngine)
        {            
            HomePage search = new HomePage(driver);
            search.GoToPage(searchEngine);
            ResultPage results = search.Criteria(searchCriteria).Search(searchEngine);            
            results.NavigateTo(results.FirstResult);            
            
            Assert.That(driver.Url, Is.EqualTo(expectedURL));
        }
    }
}
