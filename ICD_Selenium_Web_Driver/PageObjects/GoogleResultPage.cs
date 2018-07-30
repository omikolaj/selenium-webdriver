using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace ICD_Selenium_Web_Driver.PageObjects
{
    public class GoogleResultPage
    {
        #region Constructor

        /// <summary>
        /// Instantiates <see cref="GoogleResultPage"/> which represents the search result page for google
        /// </summary>
        /// <param name="driver"></param>
        public GoogleResultPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion Constructor

        #region Fields and Properties

        private IWebDriver _driver;

        /// <summary>
        /// Main Div element containing the entire list of the results
        /// </summary>
        [FindsBy(How = How.Id, Using = ("search"))]
        private IWebElement _searchReultsContainer;

        /// <summary>
        /// Returns a list of search results. Each list item represents <see cref="IWebElement"/>
        /// </summary>
        public IReadOnlyCollection<IWebElement> SearchResultsList => _searchReultsContainer.FindElements(By.ClassName("g"));

        /// <summary>
        /// Returns the first <see cref="IWebElement"/> item from the <see cref="SearchResultsList"/> 
        /// </summary>
        public virtual IWebElement FirstResult => SearchResultsList.FirstOrDefault(r => r.FindElement(By.ClassName("r")) is IWebElement);

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
        public virtual GoogleResultPage NavigateTo(IWebElement result)
        {
            FirstATagResult.Click();
            _driver.SwitchTo().DefaultContent();
            return this;
        }

        #endregion Methods

    }
}
