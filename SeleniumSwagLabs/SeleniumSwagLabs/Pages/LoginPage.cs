
using OpenQA.Selenium;

namespace SeleniumSwagLabs
{
	public class LoginPage : UtilityClass
	{
		private IWebDriver driver;

		private By username = By.Id("user-name");
		private By password = By.Name("password");
		private By loginButton = By.XPath("//*[@id='login-button']");
		private By Click_on_hamburger = By.Id("react-burger-menu-btn");
		private By Click_on_About = By.XPath("//*[@id='about_sidebar_link']");
		




		public LoginPage(IWebDriver driver)
		{
			this.driver = driver;
		}


		public void LoginUsername(string usernameValue)
		{
			driver.FindElement(username).SendKeys("standard_user");
		}


		public void LoginPassword(string passwordValue)
		{
			driver.FindElement(password).SendKeys("secret_sauce");
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

	    




	}
    }


