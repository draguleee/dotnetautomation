using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using page_objects;
using System.Reflection;

namespace tests
{
    /// <summary>
    /// TestBase class - represents the base class for all tests.
    /// </summary>
    [TestFixture]   
    public class TestBase
    {
        // Create the class instances for IWebDriver, Actions, WebDriverWait and IndexPage here
        private IWebDriver driver;
        private WebDriverWait wait;
        private IndexPage indexPage;

        /// <summary>
        /// SetUp method - runs before each test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\.Drivers");
            driver.Url = TestData.PathToIndex;
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            indexPage = new IndexPage(driver);
        }

        /// <summary>
        /// GetDriver method - returns the current instance of IWebDriver.
        /// </summary>
        /// <returns></returns>
        public IWebDriver GetDriver()
        {
            return driver;
        }

        /// <summary>
        /// GetIndexPage method - returns the current instance of IndexPage.
        /// </summary>
        /// <returns></returns>
        public IndexPage GetIndexPage()
        {
            return indexPage;
        }

        /// <summary>
        /// TearDown method - runs after each test.
        /// </summary>
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
