using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace FinalAssignmentTests.Base
{
    /// <summary>
    /// TestBase - represents the base class for all the tests.
    /// </summary>
    public class TestBase
    {
        // Create the instances for the driver and wait
        protected IWebDriver Driver { get; set; }

        /// <summary>
        /// SetupReport method - runs once before all tests to initialize the report.
        /// </summary>
        [OneTimeSetUp]
        public void SetupReport()
        {
            Reporter.InitReport();
        }

        /// <summary>
        /// SetUp method - runs before each test.   
        /// </summary>
        [SetUp]
        public virtual void SetUp()
        {
            // Start WebDriver
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\.Drivers");
            Driver.Manage().Window.Maximize();

            // Start Reporter
            var className = GetType().Name;
            var testName = TestContext.CurrentContext.Test.MethodName;
            Reporter.CreateTest(className, testName);
            Reporter.CurrentTest.AssignCategory(className);
        }

        /// <summary>
        /// TearDown method - runs after each test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            Reporter.LogInfo("TearDown: Closing browser.");
            Reporter.FinalizeTest();
            if (Driver != null)
            {
                Driver.Quit();
            }
        }

        /// <summary>
        /// OneTimeTearDown method - runs once after all tests to flush the report.
        /// </summary>
        [OneTimeTearDown]
        public void CleanupReport()
        {
            Reporter.FlushReport();
        }

        public static void CreateTest(string className, string testName)
        {
            var parent = Reporter.Extent.CreateTest(className);
            Reporter.test.Value = parent.CreateNode(testName);
        }

    }
}
