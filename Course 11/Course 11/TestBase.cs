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

namespace Course_11
{
    [TestFixture]
    public class TestBase
    {
        // Create instances for IWebDriver, Actions and IndexPage
        public IWebDriver driver;
        public Actions actions;
        public IndexPage indexPage;

        // Method that runs before each test
        [SetUp]
        public virtual void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\.Drivers");
            driver.Url = "C:\\Users\\aandr\\source\\repos\\dotnetautomation\\Course 11\\Course 11\\.Pages\\index.html";
            driver.Manage().Window.Maximize();
            actions = new Actions(driver);
            indexPage = new IndexPage(driver);
        }

        // Method that runs after each test
        [TearDown]
        public void TearDown()
        {   
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
