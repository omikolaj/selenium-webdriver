using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ICD_Selenium_Web_Driver.PageObjects
{
    public class ICDPortalLogin
    {
        #region Constructor

        /// <summary>
        /// Instantiates <see cref="ICDPortalLogin"/> that represents the customer's ICD Portal Login site
        /// </summary>
        public ICDPortalLogin(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion Constructor

        #region Fields and Properties

        private IWebDriver _driver;

        /// <summary>
        /// Returns the main ICD Portal Login div container
        /// </summary>
        //[FindsBy(How = How.ClassName, Using = ("container"))]
        private IWebElement _mainContainer => _driver.SwitchTo().DefaultContent().FindElement(By.ClassName("container"));

        /// <summary>
        /// Finds the div representing the body of the login dialog
        /// </summary>
        [FindsBy(How = How.ClassName, Using =("bodyLogin"))]
        private IWebElement _bodyLogin;

        /// <summary>
        /// Returns the contents of the error message, if there is no error message it returns an empty string
        /// </summary>
        public virtual string ErrorMessage
        {
            get
            {
                string _errorMessage = string.Empty;
                try
                {
                    _errorMessage =  _mainContainer.FindElement(By.CssSelector("#login>div>div")).Text;
                }
                catch
                {
                    return _errorMessage;
                }
                return _errorMessage;
            }
        }

        /// <summary>
        /// Indicates rather the error message is displayed or not
        /// </summary>
        public virtual bool IsErrorMessageDisplayed => ErrorMessage.Contains("Invalid");

        /// <summary>
        /// Username input field
        /// </summary>
        public virtual IWebElement Username
        {
            get => _bodyLogin.FindElement(By.Id("j_username"));
            set { }
        }

        /// <summary>
        /// Password input field
        /// </summary>
        public virtual IWebElement Password
        {
            get => _bodyLogin.FindElement(By.Id("j_password"));
            set { }
        }

        #endregion Fields and Properties

        #region Methods

        /// <summary>
        /// Selects the login button
        /// </summary>
        public virtual void Login()
        {
            _bodyLogin.FindElement(By.Id("loginButton")).Click();
        }

        /// <summary>
        /// Navigates the browser to the specified URL
        /// </summary>
        /// <param name="searchEngine"></param>
        public void GoToPage(string website)
        {
            _driver.Navigate().GoToUrl(website);
        }

        #endregion Methods

    }
}
