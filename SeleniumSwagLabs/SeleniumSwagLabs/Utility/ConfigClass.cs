using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SeleniumSwagLabs
{
    public class ConfigClass
    {
        public static IWebDriver driver;
        public static string chromeDriverPath = @"C:\Users\PANDURANG\source\repos\SeleniumSwagLabs\SeleniumSwagLabs\Drivers";
        // public static string geckoDriverPath = @"C:\Users\PANDURANG\source\repos\SeleniumSwagLabs\SeleniumSwagLabs\Drivers\geckodriver.exe";

        public static string url = "https://www.saucedemo.com/";

        public static string filePath = @"C:\Users\PANDURANG\source\repos\SeleniumSwagLabs\SeleniumSwagLabs\Screeshots\";

        public static int PAGE_LOAD_TIMEOUT = 5;
        public static int IMPLICIT_WAIT = 5;

        public static Actions action;
    }
}
