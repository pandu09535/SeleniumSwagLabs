
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SeleniumSwagLabs
{
    [Binding]
    public class LoginStepDefinitions : UtilityClass
    {
        public LoginPage lp;
        public HomePage hp;
        public Contactsales cs;
        public GeneralInquiries GI;
        public ContactSupport CS;
        public SauceCommunity SC;

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("CHROME");
            browserMaximize();
            LaunchApp(url);
        }
        public void ObjectMethod()
        {
            lp = new LoginPage(driver);
            hp = new HomePage(driver);
            cs = new Contactsales(driver);
            GI = new GeneralInquiries(driver);
            CS = new ContactSupport(driver);
            SC = new SauceCommunity(driver);
        }

            [Given(@"Chrome is Opened and SwagLab app is Opened")]
        public void GivenChromeIsOpenedAndSwagLabAppIsOpened()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            string expectedTitle = "Swag Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
        }

        [When(@"User enters correct Username ""([^""]*)"" and Password ""([^""]*)""")]
        public void WhenUserEntersCorrectUsernameAndPassword(string uname, string pword)
        {
            ObjectMethod();
            Thread.Sleep(5000);
            lp.LoginUsername(uname);
            lp.LoginPassword(pword);
        }

        [When(@"User Click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            hp = lp.LoginButton();
        }

        [Then(@"It Shows home page")]
        public void ThenItShowsHomePage()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            String expectedTitle = "Swag Labs";
            String actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        [When(@"User click on Hamburger")]
        public void ThenUserClickOnHamburger()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            lp.hamburger();

        }

        [Then(@"It Shows lists of components")]
        public void ThenItShowsListsOfComponents()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            String expectedTitle = "Swag Labs";
            String actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        [Then(@"User clicks on About")]
        public void ThenUserClicksOnAbout()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            lp.About();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            CloseBrowser();
        }



    }
}
