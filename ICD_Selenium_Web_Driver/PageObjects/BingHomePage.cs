using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace ICD_Selenium_Web_Driver.PageObjects
{
    public class BingHomePage
    {
        #region Constructor

        /// <summary>
        /// Instantiates <see cref="BingHomePage"/> that represents bing.com landing page
        /// </summary>
        /// <param name="driver"></param>
        public BingHomePage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion Constructor

        #region Fields and Properties

        private IWebDriver _driver;

        /// <summary>
        /// <see cref="BingHomePage"/> search button
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "input[title='Search']")]
        private IWebElement _searchCriteria;


        /// <summary>
        /// <see cref="BingHomePage"/> search input field
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "input[title='Search']")]
        private IWebElement _searchBtn;

        #endregion Fields and Properties

        #region Methods

        /// <summary>
        /// Navigates the browser to the specified search engine URL
        /// </summary>
        /// <param name="searchEngine"></param>
        public void GoToPage(string searchEngine)
        {
            _driver.Navigate().GoToUrl(searchEngine);
        }

        /// <summary>
        /// Clicks the <see cref="BingHomePage"/> landing page search button
        /// </summary>
        /// <returns></returns>
        public virtual BingResultPage Search()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _searchCriteria.SendKeys(Keys.Return);
            BingResultPage resultPage = new BingResultPage(_driver);
            return resultPage;
        }

        /// <summary>
        /// Enters in the desired search criteria in the search field
        /// </summary>
        /// <param name="searchCriteria"></param>
        /// <returns></returns>
        public virtual BingHomePage Criteria(string searchCriteria)
        {
            _searchCriteria.SendKeys(searchCriteria);
            return this;
        }

        #endregion Methods







    }
}
