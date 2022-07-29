
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace SeleniumSwagLabs
{
    [Binding]
    public class ContactSalesStepDefinitions : UtilityClass
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


        [Given(@"Chrome is opened And SwagLab app is Opened")]
        public void GivenChromeIsOpenedAndSwagLabAppIsOpened()
        {
            ObjectMethod();
            Thread.Sleep(5000);
            string expectedTitle = "Swag Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
        }

        [Given(@"User enters Correct Username ""([^""]*)"" and Password ""([^""]*)""")]
        public void GivenUserEntersCorrectUsernameAndPassword(string uname, string pword)
        {
            ObjectMethod();
            Thread.Sleep(2000);
            lp.LoginUsername(uname);
            lp.LoginPassword(pword);
        }

        [When(@"User click On login button")]
        public void GivenUserClickOnLoginButton()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            hp = lp.LoginButton();
        }

        [Then(@"It shows Home page")]
        public void ThenItShowsHomePage()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            string expectedTitle = "Swag Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        [When(@"user Click on Hamburger")]
        public void ThenUserClickOnHamburger()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            lp.hamburger();
        }

        [Then(@"It shows lists of Components")]
        public void ThenItShowsListsOfComponents()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            string expectedTitle = "Swag Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        [When(@"User clicks On About")]
        public void ThenUserClicksOnAbout()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            lp.About();
        }

        [Then(@"It shows Saucelabs page")]
        public void ThenItShowsSaucelabsPage()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            string expectedTitle = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        [When(@"User Clicks on contact")]
        public void ThenUserClicksOnContact()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            cs.Veiwallcontactcomponents();
        }

        [Then(@"It Shows Contact components")]
        public void ThenItShowsContactComponents()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            string expectedTitle = "Cross Browser Testing, Selenium Testing, Mobile Testing | Sauce Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        [When(@"User clicks on Contactsales")]
        public void ThenUserClicksOnContactsales()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            cs.ClickonContactsales();
        }

        [Then(@"It shows Contactsales page")]
        public void ThenItShowsContactsalesPage()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            string expectedTitle = "Contact Sales | Sauce Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }
        [When(@"User enters  FirstName ""([^""]*)""")]
        public void WhenUserEntersFirstName(string panduranga)
        {
            ObjectMethod();
            Thread.Sleep(2000);
            cs.UserFirstname(panduranga);
        }

        [When(@"User enters Lastname ""([^""]*)""")]
        public void WhenUserEntersLastname(string sangde)
        {
            ObjectMethod();
            Thread.Sleep(2000);
            cs.UserLastname(sangde);
        }

        [When(@"user enters companyname ""([^""]*)""")]
        public void WhenUserEntersCompanyname(string saucelabs)
        {
            ObjectMethod();
            Thread.Sleep(2000);
            cs.UserCompanyname(saucelabs);
        }

        [When(@"user enters Businessmail ""([^""]*)""")]
        public void WhenUserEntersBusinessmail(string umail)
        {
            ObjectMethod();
            Thread.Sleep(2000);
            cs.UserBusinessmail(umail);
        }
        
        [When(@"user select the Companysize")]
        public void WhenUserSelectTheCompanysize()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            cs.SelectingCompanySizeDropdown();
            Thread.Sleep(5000);
        }

        [When(@"user select the Countryname")]
        public void WhenUserSelectTheCountryname()
        {
            ObjectMethod();
            Thread.Sleep(2000);
            cs.SelectingCountrySizeDropdown();
            Thread.Sleep(5000);
        }



        [When(@"user enters PhoneNumber ""([^""]*)""")]
        public void WhenUserEntersPhoneNumber(string pnumber)
        {
            ObjectMethod();
            Thread.Sleep(2000);
            cs.UserPhoneNumber(pnumber);
        }
       
        /*
        [When(@"user click on CrossbrowserTesting checkbox")]
        public void WhenUserClickOnCrossbrowserTestingCheckbox()
        {
            Thread.Sleep(2000);
            cs.CrossbrowserTestingCheckbox();
        }
        */
        
        [When(@"user fills how did u hear about us Textarea ""([^""]*)""")]
        public void WhenUserFillsHowDidUHearAboutUsTextarea(string Text)
        {
            ObjectMethod();
            Thread.Sleep(2000);
            cs.Textarea(Text);
        }

        [When(@"user fills comments in commentbox ""([^""]*)""")]
        public void WhenUserFillsCommentsInCommentbox(string comment)
        {
            ObjectMethod();
            Thread.Sleep(2000);
            cs.CommentBox(comment);
            Thread.Sleep(2000);
        }
        /*
        [When(@"user clicks on privacy policy checkbox")]
        public void WhenUserClicksOnPrivacyPolicyCheckbox()
        {
            Thread.Sleep(2000);
            cs.CheckBoxPrivacy();
        }
        
        
        [When(@"user clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            IWebElement exp = cs.submitbutton();
            Hover(exp);
            
            Thread.Sleep(5000);
            /*
            cs.ClickonSubmitButton();
            Thread.Sleep(2000);
            
        }

        [Then(@"It shows thanks for submitting request")]
        public void ThenItShowsThanksForSubmittingRequest()
        {
            Thread.Sleep(2000);
            string expectedTitle = "Contact Sales | Sauce Labs";
            string actualTitle = ValidatePageTitle();
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));
            Console.WriteLine(actualTitle);
            CaptureScreenshot();
        }

        */










    }
}
