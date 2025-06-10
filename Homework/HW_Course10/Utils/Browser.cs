using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Utils
{
    public class Browser
    {
        // Method using explicit wait to find an element
        public static IWebElement ExplicitWait(IWebDriver driver, By locator, int timeoutSeconds)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        // Method using fluent wait to find an element
        public static IWebElement FluentWait(IWebDriver driver, By locator, int timeoutSeconds)
        {
            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(timeoutSeconds),
                PollingInterval = TimeSpan.FromMilliseconds(5000),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return wait.Until(drv =>
            {
                var element = drv.FindElement(locator);
                return element.Displayed ? element : null;
            }); 
        }
    }
}
