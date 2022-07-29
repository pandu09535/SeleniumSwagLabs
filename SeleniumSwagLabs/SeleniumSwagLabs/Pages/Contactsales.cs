
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Collections;
using System.Linq;

namespace SeleniumSwagLabs
{
    public class Contactsales : UtilityClass
    {
        private IWebDriver driver;

        private By username = By.Id("user-name");
        private By password = By.Name("password");
        private By loginButton = By.XPath("//*[@id='login-button']");
        private By Click_on_hamburger = By.Id("react-burger-menu-btn");
        private By Click_on_About = By.XPath("//*[@id='about_sidebar_link']");
        private By Click_on_Contact_sales = By.XPath("(//*[text()='Contact Sales'])[2]");
        private By Firstname = By.XPath("//*[@id='FirstName']");
        private By Lastname = By.XPath("//input[@name='LastName']");
        private By Companyname = By.XPath("//input[@id='Company'] ");
        private By Businessmail = By.XPath("//input[@name='Email']");
        // private By Select_Comapany_Size = By.Id("Company_Size__c");
        private By PhoneNumber = By.XPath("//input[@name='Phone']");
        // private By Cross_Browser_Tesing = By.Id("mktoCheckbox_30954_0");
        private By How_Did_You_Hear_About_Us = By.XPath("//textarea[@id='How_did_you_hear_about_Sauce_Labs__c']");
        private By Comment_Box = By.XPath("//textarea[@name='Sales_Contact_Comments__c']");
        // private By Check_Box_For_Policy = By.XPath("//input[@name='sauceLabsContactConsent']");
        // private By Click_Submit_Button = By.XPath("(//button [@type='submit'])[2]");


        public Contactsales(IWebDriver driver)
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
            // driver.FindElement(Veiw_all_contact_components).Click();

        }

        public void ClickonContactsales()
        {

            IWebElement secondElement = driver.FindElement(By.XPath("(//*[text()='Contact Sales'])[2]"));
            Actions action = new Actions(driver);
            action.MoveToElement(secondElement).Perform();
            driver.FindElement(Click_on_Contact_sales).Click();

        }
        public void UserFirstname(string FirstnameValue)
        {
            driver.FindElement(Firstname).SendKeys(FirstnameValue);
        }

        public void UserLastname(string LastnameValue)
        {
            driver.FindElement(Lastname).SendKeys(LastnameValue);
        }

        public void UserCompanyname(string CompanynameValue)
        {
            driver.FindElement(Companyname).SendKeys(CompanynameValue);
        }

        public void UserBusinessmail(string BusinessmailValue)
        {
            driver.FindElement(Businessmail).SendKeys(BusinessmailValue);
        }

        public void SelectingCompanySizeDropdown()
        {
            IWebElement dropdownElement = driver.FindElement(By.Id("Company_Size__c"));
            SelectElement dropdown = new SelectElement(dropdownElement);
            dropdown.SelectByValue("2-10");
            dropdown.SelectByIndex(2);


            /*
            IWebElement secondElement = driver.FindElement(Select_Comapany_Size);
            secondElement.Click();
           
            Actions action = new Actions(driver);
            action.MoveToElement(secondElement).Perform();
            driver.FindElement(Select_Comapany_Size).Click();
            */
        }
        public void SelectingCountrySizeDropdown()
        {
            IWebElement dropdownElement = driver.FindElement(By.Id("Country"));
            SelectElement dropdown = new SelectElement(dropdownElement);
            dropdown.SelectByValue("Afghanistan");
            dropdown.SelectByIndex(1);
        }





        public void UserPhoneNumber(string PhoneNumberValue)
        {
            driver.FindElement(PhoneNumber).SendKeys(PhoneNumberValue);
        }
        /*
        public void CrossbrowserTestingCheckbox()
        {
            driver.FindElement(Cross_Browser_Tesing).Click();
        
            //OR
            /*
            IWebElement checkbox1 = driver.FindElement(By.XPath("//input[@type='checkbox'][1]"));
            //OR
            //IWebElement checkbox1 = driver.FindElement(By.XPath("//form[@id='checkboxes']/input[1]"));

            checkbox1.Click();

            Console.WriteLine(checkbox1.Selected);
            
            Thread.Sleep(2000);
            
        }
        */

        public void Textarea(string Textareavalue)
        {
            driver.FindElement(How_Did_You_Hear_About_Us).SendKeys(Textareavalue);
        }

        public void CommentBox(string CommentBoxvalue)
        {
            driver.FindElement(Comment_Box).SendKeys(CommentBoxvalue);
        }
        /*
        public void CheckBoxPrivacy()
        {
            IWebElement secondElement = driver.FindElement(By.Name("sauceLabsContactConsent"));
            Actions action = new Actions(driver);
            action.MoveToElement(secondElement).Perform();
            driver.FindElement(Check_Box_For_Policy).Click();

        }
        */
        /*
        public IWebElement submitbutton()
        {
            return driver.FindElement(Click_Submit_Button);
        }
        */
        /*
        

        IWebElement Submit_Button = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/section[1]/div[1]/div[2]/div[1]/form[1]/div[18]/span[1]/button[1]"));
            Click_Submit_Button.Click();

         IWebElement Click_Submit_Button = driver.FindElement(By.CssSelector("button[class='mktoButton']"));
            Click_Submit_Button.Click();
            /*
            IWebElement secondElement = driver.FindElement(By.XPath("(//*[text()='Submit'])[1]"));
            Actions action = new Actions(driver);
            action.MoveToElement(secondElement).Perform();
            driver.FindElement(Click_Submit_Button).Click();
            */
        /*
        IWebElement secondElement = driver.FindElement(By.XPath("(//*[contains(text(),'Submit')])[1]"));
        Actions action = new Actions(driver);
        action.MoveToElement(secondElement).Perform();
        driver.FindElement(Click_Submit_Button).Click();
        */
    }



}




