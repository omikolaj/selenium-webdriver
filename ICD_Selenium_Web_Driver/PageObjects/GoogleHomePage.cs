using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace ICD_Selenium_Web_Driver.PageObjects
{
    public class GoogleHomePage
    {
        #region Constructor

        /// <summary>
        /// Instantiates <see cref="GoogleHomePage"/> that represents google.com landing page
        /// </summary>
        /// <param name="driver"></param>
        public GoogleHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion Constructor

        #region Fields and Properties

        private IWebDriver driver;

        private WebDriverWait wait;

        /// <summary>
        /// <see cref="GoogleHomePage"/> search button
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "input[aria-label='Google Search']")]
        private IWebElement _searchBtn;

        /// <summary>
        /// <see cref="GoogleHomePage"/> search input field
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "input[title='Search']")]
        private IWebElement _searchCriteria;

        #endregion Fields and Properties

        #region Methods

        /// <summary>
        /// Navigates the browser to the specified search engine URL
        /// </summary>
        /// <param name="searchEngine"></param>
        public void GoToPage(string searchEngine)
        {
            driver.Navigate().GoToUrl(searchEngine);
        }

        /// <summary>
        /// Clicks the <see cref="GoogleHomePage"/> landing page search button
        /// </summary>
        /// <returns></returns>
        public virtual GoogleResultPage Search()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _searchBtn.Click();
            GoogleResultPage resultPage = new GoogleResultPage(driver);            
            return resultPage;
        }

        /// <summary>
        /// Enters in the desired search criteria in the search field
        /// </summary>
        /// <param name="searchCriteria"></param>
        /// <returns></returns>
        public virtual GoogleHomePage Criteria(string searchCriteria)
        {
            _searchCriteria.SendKeys(searchCriteria);
            return this;
        }

        #endregion Methods


    }
}
