using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace SeleniumTest
{
    public class SeleniumTest
    {
        [Test]
        public void FirstSeleniumTest()
        {
            // Set the path to the ChromeDriver executable
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");

            // Set the specified URL
            driver.Url = "https://practicetestautomation.com/practice-test-login/";

            // Maximize the browser window
            driver.Manage().Window.Maximize();

            // Check that the title of the page is correct
            Assert.That(driver.Title.Equals("Test Login | Practice Test Automation"));

            // Find the username and password input fields and enter the credentials
            driver.FindElement(By.Id("username")).SendKeys("student");
            driver.FindElement(By.Id("password")).SendKeys("Password123");

            // Find the login button and click it
            driver.FindElement(By.Id("submit")).Click();

            // Close the current instance of the driver
            // driver.Close();

            // Quit all the instances of the driver
            // driver.Quit();

        }
    }
}
