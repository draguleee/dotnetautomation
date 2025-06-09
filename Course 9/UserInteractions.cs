using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System.Reflection;

namespace Course_9
{
    [TestFixture]
    public class UserInteractions
    {
        // Create the driver instance
        private IWebDriver driver;

        // Method that runs before each test
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            driver.Manage().Window.Maximize();
        }

        // Test the header
        [Test]
        public void TestHeader()
        {
            var header = driver.FindElement(By.ClassName("jumbotron"));
            Assert.That(header.FindElement(By.ClassName("logoClass")).Displayed);
            Assert.That(header.FindElement(By.XPath("//button[text()='Home']")).Displayed);
            Assert.That(header.FindElement(By.XPath("//button[text()='Practice']")).Displayed);
            Assert.That(header.FindElement(By.XPath("//button[text()='Login']")).Displayed);
            Assert.That(header.FindElement(By.XPath("//button[text()='Signup']")).Displayed);
        }

        // Test radio buttons
        [Test]
        public void TestRadioButtons()
        {
            var radioButton1 = driver.FindElement(By.CssSelector("input[value='radio1']"));
            var radioButton2 = driver.FindElement(By.CssSelector("input[value='radio2']"));
            var radioButton3 = driver.FindElement(By.CssSelector("input[value='radio3']"));
            radioButton1.Click();
            Assert.That(radioButton1.Selected);
            radioButton2.Click();
            Assert.That(radioButton2.Selected);
            radioButton3.Click();
            Assert.That(radioButton3.Selected);
        }

        // Test textboxes
        [Test]
        public void TestTextBoxes()
        {
            var textBox = driver.FindElement(By.Id("autocomplete"));
            textBox.SendKeys("Romania");
            textBox.Clear();
            textBox.GetAttribute("type");
            textBox.GetAttribute("class");
        }

        // Test dropdowns
        [Test]
        public void TestDropdowns()
        {
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("dropdown-class-example")));
            dropdown.SelectByValue("option1");
            dropdown.SelectByValue("option2");
            dropdown.SelectByValue("option3");  
            dropdown.SelectByText("Option1");
            dropdown.SelectByText("Option2");
            dropdown.SelectByText("Option3");
        }

        // Keyboard actions
        [Test]
        public void TestKeyboardActions()
        {
            Actions action = new Actions(driver);
            var textBox = driver.FindElement(By.Id("autocomplete"));
            textBox.SendKeys("Romania");
            action.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Perform(); 
            action.KeyDown(Keys.Control).SendKeys("c").KeyUp(Keys.Control).Perform();
            action.KeyDown(Keys.Control).SendKeys("v").KeyUp(Keys.Control).Perform();
        }

        // Method that runs after each test
        [TearDown]
        public void TearDown()
        {
            // driver.Quit();
        }
    }
}