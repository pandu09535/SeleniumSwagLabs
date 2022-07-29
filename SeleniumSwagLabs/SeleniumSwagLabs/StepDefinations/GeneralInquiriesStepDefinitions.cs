
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SeleniumSwagLabs
{
    [Binding]
    public class GeneralInquiriesStepDefinitions : UtilityClass
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

        [Given(@"Chrome is opened and swagLab app is Opened")]
        public void GivenChromeIsOpenedAndSwagLabAppIsOpened()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            string expectedTitle = "Swag Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
        }

        [Given(@"USer enters correct Username ""([^""]*)"" and Password ""([^""]*)""")]
        public void GivenUserEntersCorrectUsernameAndPassword(string uname, string pword)
        {
            ObjectMethod();
            Thread.Sleep(5000);
            lp.LoginUsername(uname);
            lp.LoginPassword(pword);
        }

        [When(@"USer click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            hp = lp.LoginButton();
        }

        [Then(@"IT shows home page")]
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

        [When(@"USer click on Hamburger")]
        public void WhenUserClickOnHamburger()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            lp.hamburger();
        }

        [Then(@"IT shows lists of components")]
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

        [When(@"USer clicks on About")]
        public void WhenUserClicksOnAbout()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            lp.About();
        }

        [Then(@"IT shows saucelabs page")]
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

        [When(@"USer clicks on contact")]
        public void WhenUserClicksOnContact()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            GI.Veiwallcontactcomponents();
        }

        [Then(@"IT shows Contact components")]
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

        [When(@"User clicks on GeneralInquiries")]
        public void WhenUserClicksOnGeneralInquiries()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            GI.ClickonGeneralInquiries();
        }

        [Then(@"It shows GeneralInquiries page")]
        public void ThenItShowsGeneralInquiriesPage()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            string expectedTitle = "Contact Us | Sauce Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }
    }
}
