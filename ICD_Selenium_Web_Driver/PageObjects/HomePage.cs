using ICD_Selenium_Web_Driver.TestData;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ICD_Selenium_Web_Driver.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "input[title='Search']")]
        private IWebElement _searchCriteria;

        public void GoToPage(string searchEngine)
        {
            driver.Navigate().GoToUrl(searchEngine);
        }

        [FindsBy(How = How.CssSelector, Using = "input[aria-label='Google Search']")]
        private IWebElement _googleSearchBtn;

        [FindsBy(How = How.CssSelector, Using = "input[title='Search']")]
        private IWebElement _bingSearchBtn;

        public virtual ResultPage Search(string searchEngine)
        {
            switch (searchEngine)
            {
                case ICDTestData.Google:
                    _googleSearchBtn.Click();
                    break;
                case ICDTestData.Bing:
                    _bingSearchBtn.Click();
                    break;
                default:
                    break;
            }
            ResultPage resultPage = new ResultPage(driver);
            return resultPage;
        }

        public virtual HomePage Criteria(string searchCriteria)
        {
            _searchCriteria.SendKeys(searchCriteria);
            return this;
        }
    }
}
