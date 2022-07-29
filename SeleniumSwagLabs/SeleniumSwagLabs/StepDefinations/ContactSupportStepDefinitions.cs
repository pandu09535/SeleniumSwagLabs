
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SeleniumSwagLabs
{
    [Binding]
    public class ContactSupportStepDefinitions : UtilityClass
    {
        public LoginPage lp;
        public HomePage hp;
        public Contactsales cs;
        public GeneralInquiries GI;
        public ContactSupport CS;
        public SauceCommunity SC;

        public void ObjectMethod()
        {
            lp = new LoginPage(driver);
            hp = new HomePage(driver);
            cs = new Contactsales(driver);
            GI = new GeneralInquiries(driver);
            CS = new ContactSupport(driver);
            SC = new SauceCommunity(driver);
        }

        [Given(@"Chrome is opened and SwagLab App is Opened")]
        public void GivenChromeIsOpenedAndSwagLabAppIsOpened()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            string expectedTitle = "Swag Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
        }

        [Given(@"User enters correct Username ""([^""]*)"" And Password ""([^""]*)""")]
        public void GivenUserEntersCorrectUsernameAndPassword(string uname, string pword)
        {
            ObjectMethod();
            Thread.Sleep(5000);
            lp.LoginUsername(uname);
            lp.LoginPassword(pword);
        }

        [When(@"User click on login Button")]
        public void WhenUserClickOnLoginButton()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            hp = lp.LoginButton();
        }

        [Then(@"It shows home Page")]
        public void ThenItShowsHomePage()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            string expectedTitle = "Swag Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        [When(@"user click On Hamburger")]
        public void WhenUserClickOnHamburger()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            lp.hamburger();
        }

        [Then(@"It shows Lists of components")]
        public void ThenItShowsListsOfComponents()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            string expectedTitle = "Swag Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        [When(@"User Clicks on About")]
        public void WhenUserClicksOnAbout()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            lp.About();
        }

        [Then(@"It Shows saucelabs page")]
        public void ThenItShowsSaucelabsPage()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            string expectedTitle = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        [When(@"User clicks On contact")]
        public void WhenUserClicksOnContact()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            CS.Veiwallcontactcomponents();
        }

        [Then(@"It shows contact components")]
        public void ThenItShowsContactComponents()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            string expectedTitle = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        [When(@"User clicks on ContactSupport")]
        public void WhenUserClicksOnContactSupport()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            CS.ClickonContactSupport();
        }

        [Then(@"It shows ContactSupport page")]
        public void ThenItShowsContactSupportPage()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            string expectedTitle = "Support and Services | Sauce Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        [Then(@"User clicks on Getsupport")]
        public void ThenUserClicksOnGetsupport()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            CS.GetSupport();
        }







    }






}

