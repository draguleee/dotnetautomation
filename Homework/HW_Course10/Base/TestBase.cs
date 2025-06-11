using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace Base
{
    [TestFixture]
    public class TestBase
    {
        // Declare driver at class level so it can be used in multiple tests
        public IWebDriver driver;

        // Method that runs before each test
        [SetUp]
        public virtual void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Manage().Window.Maximize();
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
