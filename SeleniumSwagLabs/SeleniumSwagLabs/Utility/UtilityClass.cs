using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace SeleniumSwagLabs
{
    public class UtilityClass : ConfigClass

    {
        public void LaunchBrowser(string browser)
        {
            switch (browser)
            {

                case "CHROME":
                    driver = new ChromeDriver(chromeDriverPath);
                    break;

                //  case "FIREFOX":
                //    driver = new FirefoxDriver(geckoDriverPath);
                //  break;

                default: throw new ArgumentException("Error");



            }
        }

        public void browserMaximize()
        {
            driver.Manage().Window.Maximize();
        }

        public void PageLoad()
        {
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(PAGE_LOAD_TIMEOUT);
        }

        public void ImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(IMPLICIT_WAIT);
        }

        public void LaunchApp(string url)
        {
            driver.Url = url;
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }

        public string ValidatePageTitle()
        {
            return driver.Title;
        }

        public void Hover(IWebElement element)
        {
            action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void CaptureScreenshot()
        {

            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;

            Screenshot screenshot = screenshotDriver.GetScreenshot();

            screenshot.SaveAsFile(filePath + "/screenshot.png", ScreenshotImageFormat.Png);


        }
    }
}
