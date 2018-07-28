using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace ICD_Selenium_Web_Driver.PageObjects
{
    public class BingResultPage
    {
        #region Constructor

        /// <summary>
        /// Instantiates <see cref="BingResultPage"/> which represents the search result page for bing
        /// </summary>
        public BingResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion Constructor

        #region Fields and Properties

        private IWebDriver driver;

        /// <summary>
        /// Main Div element containing the entire list of the results
        /// </summary>
        [FindsBy(How = How.Id, Using = ("b_content"))]
        private IWebElement _searchReultsContainer;

        /// <summary>
        /// Returns a list of search results. Each list item represents <see cref="IWebElement"/>
        /// </summary>
        public IReadOnlyCollection<IWebElement> SearchResultsList => _searchReultsContainer.FindElements(By.Id("b_results"));

        /// <summary>
        /// Returns the first <see cref="IWebElement"/> item from the <see cref="SearchResultsList"/> 
        /// </summary>
        public virtual IWebElement FirstResult => SearchResultsList.FirstOrDefault(r => r.FindElement(By.ClassName("b_algo")) is IWebElement);

        /// <summary>
        /// Returns the first HTML a tag from the <see cref="FirstResult"/>
        /// </summary>
        public IWebElement FirstATagResult => FirstResult.FindElement(By.TagName("a"));

        #endregion Fields and Properties

        #region Methods

        /// <summary>
        /// Navigates to the passed in <see cref="IWebElement"/> element from the search result list
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public virtual BingResultPage NavigateTo(IWebElement result)
        {
            FirstATagResult.Click();
            driver.SwitchTo().DefaultContent();
            return this;
        }

        #endregion Methods

    }
}
