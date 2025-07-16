using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPage
{
    public class Form
    {
        // Create the necessary instances
        private readonly IWebDriver driver;

        // Constructor for the Form class
        public Form(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Method to enter the first and last name (credentials)
        public void EnterCredentials(string firstName, string lastName)
        {
            FirstName.EnterText(firstName);
            LastName.EnterText(lastName);
        }

        // Method to select the country
        public void SelectCountry(bool flag, string value)
        {
            Country.SelectDropdown(flag, value);
        }

        // Method to select languages (checkboxes)
        public void SelectLanguagesCheckbox(string[] languages)
        {
            foreach (var language in languages)
            {
                switch (language.ToLower())
                {
                    case "english": English.Click(); break;
                    case "french": French.Click(); break;
                    case "german": German.Click(); break;
                    case "romanian": Romanian.Click(); break;
                    default: throw new ArgumentException($"Language '{language}' is not supported.");
                }
            }
        }

        // Method to select languages (multi-select dropdown)
        public void SelectLanguagesMulti(bool flag, string[] languages)
        {
            foreach (var language in languages)
            {
                Languages.SelectDropdown(flag, language);
            }
        }

        // Method to select the gender
        public void SelectGender(string gender)
        {
            switch(gender.ToLower())
            {
                case "male": Male.Click(); break;
                case "female": Female.Click(); break;
                default: throw new ArgumentException($"{gender} is not supported.");
            }
        }

        // Method to submit the form
        public void SubmitForm()
        {
            Submit.Submit();
        }

        // Declare the locators
        IWebElement FirstName => driver.FindElement(By.Name("firstName"));
        IWebElement LastName => driver.FindElement(By.Name("lastName"));
        IWebElement Country => driver.FindElement(By.Id("country"));
        IWebElement English => driver.FindElement(By.Id("english"));
        IWebElement French => driver.FindElement(By.Id("french"));
        IWebElement German => driver.FindElement(By.Id("german"));
        IWebElement Romanian => driver.FindElement(By.Id("romanian"));
        IWebElement Languages => driver.FindElement(By.Id("languagesMulti"));
        IWebElement Male => driver.FindElement(By.Id("male"));
        IWebElement Female => driver.FindElement(By.Id("female"));
        IWebElement Submit => driver.FindElement(By.Id("submitBtn"));
    }
}
