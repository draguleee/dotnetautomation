using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Xml.Linq;

namespace page_objects
{
    /// <summary>
    /// IndexPage - represents the main page of the application.
    /// </summary>
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

        /// <summary>
        /// IndexPage constructor - parameterized constructor that initializes the driver and waits for elements to load.
        /// </summary>
        /// <param name="driver"></param>
        public IndexPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// FillInTextInputs method - fills in the text inputs from the page.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public IndexPage FillTextInputs(string firstName, string email, string password)
        {
            textInputsSection = wait.Until(d => d.FindElement(By.XPath(PageSections.TextBoxSection)));
            textInputsSection.FindElement(By.Id("first-name")).SendKeys(firstName);
            textInputsSection.FindElement(By.Id("email")).SendKeys(email);
            textInputsSection.FindElement(By.Id("password")).SendKeys(password);
            return this;
        }

        /// <summary>
        /// SelectRadioButton method - selects a radio button based on the provided value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public IndexPage SelectRadioButton(string value)
        {
            List<string> values = new List<string> { "male", "female", "other" };
            string radioXPath = string.Format(PageSections.RadioButtonSection, value);
            radioButtonsSection = wait.Until(d => d.FindElement(By.XPath(PageSections.RadioButtonSection)));   
            if (values.Contains(value))
            {
                IWebElement radioButton = radioButtonsSection.FindElement(By.XPath(radioXPath));
                radioButton.Click();
            } else
            {
                string errorMessage = string.Format(ErrorMessages.Error, string.Join(" ", values));
                throw new ArgumentException(errorMessage);   
            }
            return this;            
        }

        /// <summary>
        /// SelectCheckbox method - selects a checkbox based on the provided value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public IndexPage SelectCheckbox(string value)
        {
            List<string> values = new List<string> { "coding", "music", "traveling" };
            string checkboxXPath = string.Format(PageElements.CheckBox, value); 
            checkBoxesSection = wait.Until(d => d.FindElement(By.XPath(PageSections.CheckBoxSection)));
            if (values.Contains(value))
            {
                IWebElement checkbox = checkBoxesSection.FindElement(By.XPath(checkboxXPath));
                checkbox.Click();
            } else
            {
                string errorMessage = string.Format(ErrorMessages.Error, string.Join(" ", values));
                throw new ArgumentException(errorMessage);
            }
            return this;
        }

        /// <summary>
        /// FillTextArea method - fills in the text area with the provided text.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public IndexPage FillTextArea(string text)
        {
            textAreaSection = wait.Until(d => d.FindElement(By.XPath(PageSections.TextAreaSection)));
            textAreaSection.FindElement(By.Id("bio")).SendKeys(text);
            return this;
        }

        /// <summary>
        /// SelectFromDropdown method - selects an option from the dropdown based on the provided value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public IndexPage SelectFromDropdown(string value)
        {
            List<string> values = new List<string> { "ro", "us", "de" };
            dropDownSection = wait.Until(d => d.FindElement(By.XPath(PageSections.DropDownSection)));
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("country")));
            if (values.Contains(value))
            {
                dropdown.SelectByValue(value);
            } else
            {
                string errorMessage = string.Format(ErrorMessages.Error, string.Join(" ", values));
                throw new ArgumentException(errorMessage);
            }
            return this;
        }

        /// <summary>
        /// SubmitForm method - submits the form by clicking the submit button.
        /// </summary>
        /// <returns></returns>
        public IndexPage SubmitForm()
        {
            buttonsSection = wait.Until(d => d.FindElement(By.XPath(PageSections.ButtonsSection)));
            buttonsSection.FindElement(By.XPath(PageElements.SubmitButton)).Click();
            if (driver.Url.Contains("dashboard.html"))
            {
                IWebElement dashboardMessage = driver.FindElement(By.XPath(PageElements.DashboardMessage));
                Assert.That(dashboardMessage.Displayed);
            }
            return this;
        }

        /// <summary>
        /// ScrollToSection method - scrolls to a specific section of the page based on the index provided.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public IndexPage ScrollToSection(int index)
        {
            string sectionXPath = string.Format(PageSections.Section, index + 1);
            IWebElement section = wait.Until(d => d.FindElement(By.XPath(sectionXPath)));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", section);
            return this;
        }

        /// <summary>
        /// Wait method - pauses the execution for a specified amount of time.
        /// </summary>
        /// <param name="timeSpan"></param>
        /// <returns></returns>
        public IndexPage Wait(int timeSpan)
        {
            Thread.Sleep(timeSpan);
            return this;
        }
    }
}
