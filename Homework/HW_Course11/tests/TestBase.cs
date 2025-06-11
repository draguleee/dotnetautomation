using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using page_objects;
using System.Reflection;

namespace tests
{
    [TestFixture]   
    public class TestBase
    {
        // Create the class instances for IWebDriver, Actions, WebDriverWait and IndexPage here
        private IWebDriver driver;
        private WebDriverWait wait;
        private IndexPage indexPage;

        // Method that runs before each test
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\.Drivers");
            driver.Url = "C:\\Users\\aandr\\source\\repos\\dotnetautomation\\Homework\\HW_Course11\\page-objects\\.Pages\\index.html";
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            indexPage = new IndexPage(driver);
        }

        // Method to return the current instance of IWebDriver
        public IWebDriver GetDriver()
        {
            return driver;
        }

        // Method to return the current instance of IndexPage
        public IndexPage GetIndexPage()
        {
            return indexPage;
        }

        // Method that runs after each test
        [TearDown]
        public void TearDown()
        {
            /*
            if (driver != null)
            {
                driver.Quit();
            }
            */
        }   
    }
}
