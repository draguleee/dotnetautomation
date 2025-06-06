using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;

namespace SeleniumHomework
{
    [TestFixture]
    public class Test
    {
        // Declare the driver as a class-level variable so it can be accessed in multiple methods
        private IWebDriver driver;

        // Method that runs before each test
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "https://practicetestautomation.com/practice-test-login/";
        }

        // Test to check all the elements on the page (the important ones)
        [Test]
        public void FindElements()
        {
            TestTitle();
            TestFirstText();
            TestSecondText();
            TestUsername();
            TestPassword();
            TestSubmitButton();
        }

        // Test to check the page's title
        [Test]
        public void TestTitle()
        {
            string title = driver.Title;
            Assert.That(title, Is.EqualTo("Test Login | Practice Test Automation"));       
        }

        // Test to check if the first text is displayed
        [Test]
        public void TestFirstText()
        {
            IWebElement firstText = driver.FindElement(By.XPath("//li[contains(text(), 'engineers')]"));
            Assert.That(firstText.Text, Does.Contain("functionality"));
            Assert.That(firstText.Displayed, Is.True);
        }

        // Test to check if the second text is displayed
        [Test]
        public void TestSecondText()
        {
            IWebElement secondText = driver.FindElement(By.XPath("//li[contains(text(), 'credentials')]"));
            Assert.That(secondText.Text, Does.Contain("Login"));
            Assert.That(secondText.Displayed, Is.True);
        }

        // Test to check the username field
        [Test]
        public void TestUsername()
        {
            var username = driver.FindElement(By.Id("username"));
            Assert.That(username.Displayed, Is.True);
        }

        // Test to check the password field
        [Test]
        public void TestPassword()
        {
            var passwordField = driver.FindElement(By.Id("password"));
            Assert.That(passwordField.Displayed, Is.True);
        }

        // Test to check the submit button
        [Test]
        public void TestSubmitButton()
        {
            var submitButton = driver.FindElement(By.Id("submit"));
            Assert.That(submitButton.Displayed, Is.True);
            Assert.That(submitButton.Enabled, Is.True);
        }

        // E2E login test
        [Test]
        public void TestLogin()
        {
            var username = driver.FindElement(By.Id("username"));
            var password = driver.FindElement(By.Id("password"));
            var submitButton = driver.FindElement(By.Id("submit"));
            username.SendKeys("student");
            password.SendKeys("Password123");
            submitButton.Click();
            IWebElement successMessage = driver.FindElement(By.ClassName("post-title"));
            Assert.That(successMessage.Text, Is.EqualTo("Logged In Successfully"));
        }

        // Clean-up method
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
