using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Course10_ClassLibrary
{
    [TestFixture]
    public class Waits
    {
        // Declare the WebDriver at class level
        private IWebDriver driver;
        private IWebElement suggestionBox;

        // Method that runs before each test
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            driver.Manage().Window.Maximize();
            suggestionBox = driver.FindElement(By.Id("autocomplete"));
        }

        // Test using implicit wait
        // Implicit wait - default wait for all elements
        [Test]
        public void TestImplicitWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            suggestionBox.SendKeys("Roma");
            var suggestion = driver.FindElement(By.XPath("//li/div[text()='Romania']"));
            suggestion.Click();
            Assert.That(suggestionBox.GetAttribute("value"), Does.Contain("Romania"), "Suggestion box does not contain 'Romania' after click.");
        }

        // Test using explicit wait
        // Explicit wait - wait for a specific element or condition
        [Test]
        public void TestExplicitWait()
        {
            suggestionBox.SendKeys("Roma");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var suggestion = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//li/div[text()='Romania']")));
            suggestion.Click();
            Assert.That(suggestionBox.GetAttribute("value"), Does.Contain("Romania"), "Suggestion box does not contain 'Romania' after click.");
        }

        // Test using fluent wait
        // Fluent wait - wait for a specific condition with polling and timeout 
        [Test]
        public void TestFluentWait()
        {
            suggestionBox.SendKeys("Roma");
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
            {
                Timeout = TimeSpan.FromSeconds(15),
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            var suggestion = fluentWait.Until(drv =>
            {
                var element = drv.FindElement(By.XPath("//li/div[text()='Romania']"));
                return element.Displayed ? element : null;
            });
            suggestion.Click();
            Assert.That(suggestionBox.GetAttribute("value"), Does.Contain("Romania"), "Suggestion box does not contain 'Romania' after click.");
        }

        // Test browser navigation
        [Test]
        public void TestBrowserNavigation()
        {
            driver.FindElement(By.XPath("//button[text()='Home']")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
            Thread.Sleep(1000);
            driver.Navigate().Back();
            // driver.Navigate().Forward();
            // driver.Navigate().Refresh();
            // driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
        }

        // IsElementPresent method to check if an element is present
        private bool IsElementPresent(By element)
        {
            try
            {
                driver.FindElement(element);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
