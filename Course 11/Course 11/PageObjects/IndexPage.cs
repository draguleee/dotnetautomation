using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.Network;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Course_11.PageObjects
{
    public class IndexPage
    {
        // Create an instance of the driver
        public IWebDriver driver;
        public WebDriverWait wait;

        // Class variables (attributes)
        private IWebElement firstNameField;
        private IWebElement emailField;
        private IWebElement passwordField;
        private IWebElement radioButton;
        private IWebElement checkBox;
        private IWebElement textArea;
        private IWebElement dropdown;
        private IWebElement submitButton;
        private IWebElement resetButton;

        // Parameterized constructor for Index class
        public IndexPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Method to fill text inputs
        public IndexPage FillTextInputs(string firstName, string email, string password)
        {
            firstNameField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("first-name")));
            firstNameField.SendKeys(firstName);

            emailField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email"))); 
            emailField.SendKeys(email);

            passwordField = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
            passwordField.SendKeys(password);

            return this;
        }

        // Method to select the radio buttons
        public IndexPage SelectRadioButton(string value)
        {
            string[] values = { "male", "female", "other" };
            if (values.Contains(value))
            {
                radioButton = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='radio'][@value='" + value + "']")));
                radioButton.Click();
            } else
            {
                throw new ArgumentException("Invalid radio button value. Valid values: male, female, other");   
            }
            return this;
        }

        // Method to select the checkboxes  
        public IndexPage SelectCheckbox(string value)
        {
            string[] values = { "coding", "music", "traveling" };
            if (values.Contains(value))
            {
                checkBox = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@type='checkbox'][@value='" + value + "']")));
                checkBox.Click();
            } else
            {
                throw new ArgumentException("Invalid checkbox value. Valid values: coding, music, traveling");
            }
            return this;
        }

        // Method to fill the text area
        public IndexPage FillTextArea(string text)
        {
            textArea = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("bio")));
            textArea.SendKeys(text);
            return this;
        }

        // Method to select an option from the dropdown
        public IndexPage SelectDropdownOption(string value)
        {
            string[] values = { "ro", "us", "de" };
            dropdown = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("country")));
            SelectElement select = new SelectElement(dropdown);
            if(values.Contains(value))
            {
                select.SelectByValue(value);
            } else
            {
                throw new ArgumentException("Invalid dropdown value. Valid values: ro, us, de");
            }
            return this;
        }

        // Method to submit the form
        public IndexPage SubmitForm()
        {
            submitButton = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//button[text()='Submit']")));
            submitButton.Click();
            Assert.That(driver.Title, Does.Contain("Dashboard"), "Form submission failed or page title is incorrect.");
            return this;
        }

        // Method to scroll to the bottom of the page
        public IndexPage ScrollToBottom()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight);");
            return this;
        }

        // Method to scroll to a specific element
        public IndexPage ScrollToElement(By locator)
        {
            var element = wait.Until(ExpectedConditions.ElementExists(locator));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return this;
        }

    }
}
