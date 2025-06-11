using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Course_11.Tests
{
    [TestFixture]
    public class TestBase
    {
        // Create instances for IWebDriver and Actions
        public IWebDriver driver;
        public Actions actions;

        // Method that runs before each test
        [SetUp]
        public virtual void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\.Drivers");
            driver.Manage().Window.Maximize();
            actions = new Actions(driver);
        }

        // Method that runs after each test
        [TearDown]
        public void TearDown()
        {   /*
            if (driver != null)
            {
                driver.Quit();
            } */
        }
    }
}
