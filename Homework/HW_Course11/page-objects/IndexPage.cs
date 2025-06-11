using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;

namespace page_objects
{
    public class IndexPage
    {
        // Create instances of IWebDriver, Actions and WebDriverWait
        private IWebDriver driver;
        private WebDriverWait wait;

        // Declare the elements from the page as properties
        private IWebElement textInputsSection;
        private IWebElement radioButtonsSection;
        private IWebElement checkBoxesSection;
        private IWebElement textAreaSection;
        private IWebElement dropDownSection;
        private IWebElement buttonsSection;

        // Parameterized constructor to initialize the driver, action and wait
        public IndexPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Method to fill in the first section (text inputs)
        public IndexPage FillTextInputs(string firstName, string email, string password)
        {
            textInputsSection = wait.Until(d => d.FindElement(By.XPath("//form[@id='test-form']/div[1]")));
            textInputsSection.FindElement(By.Id("first-name")).SendKeys(firstName);
            textInputsSection.FindElement(By.Id("email")).SendKeys(email);
            textInputsSection.FindElement(By.Id("password")).SendKeys(password);
            return this;
        }

        // Method to select a radio button from the available ones
        public IndexPage SelectRadioButton(string value)
        {
            List<string> values = new List<string> { "male", "female", "other" };
            radioButtonsSection = wait.Until(d => d.FindElement(By.XPath("//form[@id='test-form']/div[2]")));   
            if (values.Contains(value))
            {
                IWebElement radioButton = radioButtonsSection.FindElement(By.XPath("//input[@type='radio'][@value='" + value + "']"));
                radioButton.Click();
            } else
            {
                throw new ArgumentException("Invalid radio button value. Valid values: male, female, other");   
            }
            return this;            
        }

        // Method to select a checkbox from the available ones
        public IndexPage SelectCheckbox(string value)
        {
            List<string> values = new List<string> { "coding", "music", "traveling" };
            checkBoxesSection = wait.Until(d => d.FindElement(By.XPath("//form[@id='test-form']/div[3]")));
            if (values.Contains(value))
            {
                IWebElement checkbox = checkBoxesSection.FindElement(By.XPath("//input[@type='checkbox'][@value='" + value + "']"));
                checkbox.Click();
            } else
            {
                throw new ArgumentException("Invalid checkbox value. Valid values: coding, music, traveling");
            }
            return this;
        }

        // Method to fill in the text area
        public IndexPage FillTextArea(string text)
        {
            textAreaSection = wait.Until(d => d.FindElement(By.XPath("//form[@id='test-form']/div[4]")));
            textAreaSection.FindElement(By.Id("bio")).SendKeys(text);
            return this;
        }

        // Method to select an option from the dropdown
        public IndexPage SelectFromDropdown(string value)
        {
            List<string> values = new List<string> { "ro", "us", "de" };
            dropDownSection = wait.Until(d => d.FindElement(By.XPath("//form[@id='test-form']/div[5]")));
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("country")));
            if (values.Contains(value))
            {
                dropdown.SelectByValue(value);
            } else
            {
                throw new ArgumentException("Invalid dropdown value. Valid values: ro, us, de");
            }
            return this;
        }

        // Method to submit the form
        public IndexPage SubmitForm()
        {
            buttonsSection = wait.Until(d => d.FindElement(By.XPath("//form[@id='test-form']/div[6]")));
            buttonsSection.FindElement(By.XPath("//button[text()='Submit']")).Click();
            if (driver.Url.Contains("dashboard.html"))
            {
                IWebElement dashboardMessage = driver.FindElement(By.XPath("//h1[contains(text(), 'Welcome')]"));
                Assert.That(dashboardMessage.Displayed);
            }
            return this;
        }

        // Method to scroll to a certain section of the page
        public IndexPage ScrollToSection(int index)
        {
            IWebElement section = wait.Until(d => d.FindElement(By.XPath("//form[@id='test-form']/div[" + index + "]")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", section);
            return this;
        }

        // Wait for a certain timespan for an element to be viewable in the browser
        public IndexPage Wait(int timeSpan)
        {
            Thread.Sleep(timeSpan);
            return this;
        }
    }
}
