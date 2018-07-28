using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace ICD_Selenium_Web_Driver.PageObjects
{
    public class ResultPage
    {
        private IWebDriver driver;

        public ResultPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = ("search"))]
        private IWebElement _searchReultsContainer;

        public IReadOnlyCollection<IWebElement> SearchResultsList => _searchReultsContainer.FindElements(By.ClassName("g"));

        public virtual IWebElement FirstResult => SearchResultsList.FirstOrDefault(r => r.FindElement(By.ClassName("r")) is IWebElement);

        public IWebElement FirstATagResult => FirstResult.FindElement(By.TagName("a"));        

        public virtual ResultPage NavigateTo(IWebElement result)
        {            
            FirstATagResult.Click();
            driver.SwitchTo().DefaultContent();            
            return this;
        }

    }
}
