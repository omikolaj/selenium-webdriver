using ICD_Selenium_Web_Driver.PageObjects;
using ICD_Selenium_Web_Driver.TestData;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ICDSearch.Specs
{
    [Binding]
    public class InvalidCredentialsLoginSteps
    {
        #region Fields and Properties

        private IWebDriver _driver;
        private ICDPortalLogin _loginPage;

        #endregion Fields and Properties

        #region SetUp and TearDown

        [BeforeScenario("InvalidCredentials")]
        public void Setup()
        {
            _driver = new ChromeDriver();            
            _driver.Manage().Window.Maximize();
           _loginPage = new ICDPortalLogin(_driver);
        }

        [AfterScenario("InvalidCredentials")]
        public void TearDown()
        {
            _driver.Close();
        }

        #endregion SetUp and TearDown

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {            
           _loginPage.GoToPage(ICDTestData.ICDPortalLogin);
        }
        
        [When(@"I fill in Username field with ""(.*)""")]
        public void WhenIFillInUsernameFieldWith(string username)
        {
            _loginPage.Username.SendKeys(username);
        }
        
        [When(@"I fill in Password field with ""(.*)""")]
        public void WhenIFillInPasswordFieldWith(string password)
        {
            _loginPage.Password.SendKeys(password);
        }
        
        [When(@"I press the Login button")]
        public void WhenIPressTheLoginButton()
        {
            _loginPage.Login();
        }
        
        [Then(@"he should see ""(.*)"" message")]
        public void ThenHeShouldSeeMessage(string errorMessage)
        {
            bool errorMessageDisplayed = _loginPage.IsErrorMessageDisplayed;

            Assert.IsTrue(errorMessageDisplayed, "The error message was not found");
        }
    }
}
