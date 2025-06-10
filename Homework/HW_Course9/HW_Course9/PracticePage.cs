using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Reflection;

namespace HW_Course9
{
    [TestFixture]
    public class PracticePage
    {
        // Declare the driver variable to be used in the tests
        private IWebDriver driver;
        private IWebElement header;

        // Method executed before each test
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\Drivers");
            driver.Url = "https://rahulshettyacademy.com/AutomationPractice/";
            driver.Manage().Window.Maximize();
            header = driver.FindElement(By.ClassName("jumbotron"));
        }

        // Test the image header 
        [Test]
        public void TestHeaderImage()
        {
            header.FindElement(By.ClassName("logoClass")).Click();
            Assert.That(driver.Url, Is.EqualTo("https://rahulshettyacademy.com/"));
            Assert.That(driver.FindElement(By.XPath("//span[contains(text(), 'Academy')]")).Displayed);
            driver.Navigate().Back();
        }

        // Test the header buttons (Home only, the rest are not implemented)    
        [Test]
        public void TestHeaderButtons()
        {
            Assert.That(header.FindElement(By.XPath("//button[text()='Practice']")).Displayed);
            Assert.That(header.FindElement(By.XPath("//button[text()='Login']")).Displayed);
            Assert.That(header.FindElement(By.XPath("//button[text()='Signup']")).Displayed);
            header.FindElement(By.XPath("//button[text()='Home']")).Click();
            Assert.That(driver.Url, Is.EqualTo("https://rahulshettyacademy.com/"));
            Assert.That(driver.FindElement(By.XPath("//span[contains(text(), 'Academy')]")).Displayed);
            driver.Navigate().Back();
        }

        // Test the title of the page
        [Test]
        public void TestPageTitle()
        {
            var title = driver.FindElement(By.XPath("//h1[contains(text(), 'Practice')]"));
            Assert.That(title.Text, Is.EqualTo("Practice Page"), "The title of the page is not as expected.");
        }

        // Test the radio buttons
        [Test]
        public void TestRadioButtons()
        {
            var radioButtons = driver.FindElement(By.Id("radio-btn-example"));
            for (int i = 1; i <= 3; i++)
            {
                var radioButton = radioButtons.FindElement(By.CssSelector("input[value='radio" + i + "']"));
                radioButton.Click();
                Assert.That(radioButton.Selected, Is.True, "Radio button " + i + " should be selected after clicking.");
            }
        }

        // Test the suggestion box
        [Test]
        public void TestSuggestionBox()
        {
            var suggestionBox = driver.FindElement(By.Id("autocomplete"));
            var placeholder = suggestionBox.GetAttribute("placeholder");
            Assert.That(placeholder, Does.Contain("Countries"));
            suggestionBox.SendKeys("Roma");
            Thread.Sleep(2000);
            var suggestion = driver.FindElement(By.XPath("//li[@class='ui-menu-item']/div[text()='Romania']"));
            suggestion.Click();
            Assert.That(suggestionBox.GetAttribute("value"), Is.EqualTo("Romania"), "The suggestion box did not select the expected country.");
        }

        // Test the dropdown menu
        [Test]
        public void TestDropdownMenu()
        {
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("dropdown-class-example")));
            for (int i = 1; i <= 3; i++)
            {
                dropdown.SelectByValue("option" + i);
                Assert.That(dropdown.SelectedOption.Text, Is.EqualTo("Option" + i), "The dropdown did not select the expected option.");
            }
        }

        // Test the checkboxes section
        [Test]
        public void TestCheckboxes()
        {
            var checkboxes = driver.FindElement(By.Id("checkbox-example"));
            for (int i = 1; i <= 3; i++)
            {
                var checkbox = checkboxes.FindElement(By.Id("checkBoxOption" + i));
                checkbox.Click();
                Assert.That(checkbox.Selected, Is.True, "Checkbox " + i + " should be selected initially.");
            }
        }

        // Method executed after each test
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
