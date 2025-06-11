using Course_11.Base;
using Course_11.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_11.Tests
{
    [TestFixture]
    public class TestIndexPage : TestBaseIndex
    {
        // E2E login test
        [Test]
        public void LogIn()
        {
            index.FillTextInputs("Andre", "aandreid14@gmail.com", "12345678"); 
            Thread.Sleep(2000); 

            index.ScrollToElement(By.XPath("//form[@id='test-form']/div[1]"));
            index.SelectRadioButton("female");
            Thread.Sleep(2000); 

            index.ScrollToElement(By.XPath("//form[@id='test-form']/div[2]"));
            index.SelectCheckbox("coding");
            Thread.Sleep(2000); 

            index.ScrollToElement(By.XPath("//form[@id='test-form']/div[3]"));
            index.FillTextArea("This is a test message.");
            Thread.Sleep(2000); 

            index.ScrollToElement(By.XPath("//form[@id='test-form']/div[4]"));
            index.SelectDropdownOption("ro");
            Thread.Sleep(2000); 

            index.ScrollToElement(By.XPath("//form[@id='test-form']/div[5]"));
            index.SubmitForm();
            Thread.Sleep(2000);


        }
    }
}
