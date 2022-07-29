
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections;
using System.Linq;

namespace SeleniumSwagLabs
{
    public class SauceCommunity : UtilityClass
    {
        private IWebDriver driver;

        private By username = By.Id("user-name");
        private By password = By.Name("password");
        private By loginButton = By.XPath("//*[@id='login-button']");
        private By Click_on_hamburger = By.Id("react-burger-menu-btn");
        private By Click_on_About = By.XPath("//*[@id='about_sidebar_link']");
        private By Click_on_SauceCommunity = By.XPath("(//*[text()='Sauce Community'])[2]");

        public SauceCommunity(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void LoginUsername(string usernameValue)
        {
            driver.FindElement(username).SendKeys(usernameValue);
        }


        public void LoginPassword(string passwordValue)
        {
            driver.FindElement(password).SendKeys(passwordValue);
        }

        public HomePage LoginButton()
        {
            driver.FindElement(loginButton).Click();
            return new HomePage(driver);
        }

        public void hamburger()
        {
            driver.FindElement(Click_on_hamburger).Click();
        }

        public void About()
        {
            driver.FindElement(Click_on_About).Click();
        }




        public void Veiwallcontactcomponents()
        {
            IWebElement secondElement = driver.FindElement(By.XPath("(//*[text()='Contact'])[2]"));
            Actions action = new Actions(driver);
            action.MoveToElement(secondElement).Perform();


        }

        public void ClickonSauceCommunity()
        {

            IWebElement secondElement = driver.FindElement(By.XPath("(//*[text()='Sauce Community'])[2]"));
            Actions action = new Actions(driver);
            action.MoveToElement(secondElement).Perform();
            driver.FindElement(Click_on_SauceCommunity).Click();

        }

    }







}
