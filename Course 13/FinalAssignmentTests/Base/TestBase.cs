using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace FinalAssignmentTests.Base
{
    /// <summary>
    /// TestBase - represents the base class for all the tests.
    /// </summary>
    [TestFixture]
    public class TestBase
    {
        // Create the instances for the driver and wait
        protected IWebDriver Driver { get; set; }

        /// <summary>
        /// SetUp method - runs before each test.   
        /// </summary>
        [SetUp]
        public virtual void SetUp()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\.Drivers");
            Driver.Manage().Window.Maximize();  
        }

        /// <summary>
        /// TearDown method - runs after each test.
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            
            if (Driver != null)
            {
                Driver.Quit();
            }
        }   
    }
}
