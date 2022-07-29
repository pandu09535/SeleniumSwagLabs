
using TechTalk.SpecFlow;

namespace SeleniumSwagLabs
{
    public class AppicationHooks : UtilityClass

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



            lp = new LoginPage(driver);
            hp = new HomePage(driver);
             cs = new Contactsales(driver);
             GI=new GeneralInquiries(driver);
            CS = new ContactSupport(driver);
            SC = new SauceCommunity(driver);

            Thread.Sleep(2000);

        }
        
        [AfterScenario]
        public void AfterScenario()
        {
            Thread.Sleep(5000);
            CloseBrowser();
        }
        
    }
}
