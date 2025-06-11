using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_11
{
    [TestFixture]
    public class TestIndexPage : TestBase
    {
        // E2E login test
        [Test]
        public void LogIn()
        {
            indexPage.FillTextInputs("Andre", "aandreid14@gmail.com", "12345678"); 
            Thread.Sleep(2000); 

            indexPage.ScrollToElement(By.XPath("//form[@id='test-form']/div[1]"));
            indexPage.SelectRadioButton("female");
            Thread.Sleep(2000); 

            indexPage.ScrollToElement(By.XPath("//form[@id='test-form']/div[2]"));
            indexPage.SelectCheckbox("coding");
            Thread.Sleep(2000); 

            indexPage.ScrollToElement(By.XPath("//form[@id='test-form']/div[3]"));
            indexPage.FillTextArea("This is a test message.");
            Thread.Sleep(2000); 

            indexPage.ScrollToElement(By.XPath("//form[@id='test-form']/div[4]"));
            indexPage.SelectDropdownOption("ro");
            Thread.Sleep(2000); 

            indexPage.ScrollToElement(By.XPath("//form[@id='test-form']/div[5]"));
            indexPage.SubmitForm();
            Thread.Sleep(2000);

        }
    }
}
