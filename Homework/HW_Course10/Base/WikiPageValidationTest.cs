using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Base
{
    [TestFixture]
    public class WikiPageValidationTest : TestBase
    {
        // Method that runs before each test - overriding the base class SetUp method
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            driver.Url = "file:///C:/Users/ADragu/source/repos/dotnetautomation/Homework/HW_Course10/Base/Pages/WikiPage.html";
        }

        // Test to validate the title of the wiki page
        [Test]
        public void TestWikiPageTitle()
        {
            var pageTitle =  driver.Title;
            Assert.That(pageTitle, Is.EqualTo("Wiki Page"));
        }

        // Test to validate the header text on the wiki page
        [Test]
        public void TestHeaderText()
        {
            var headerText = driver.FindElement(By.XPath("//h1[contains(text(), 'Wiki')]")).Text;
            Assert.That(headerText, Does.Contain("Page"), "Paragraph text does not contain 'Page'");
        }

        // Test to validate the dropdown selection on the wiki page
        [Test]
        public void TestDropdownSelection()
        {
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("htmlSelect")));
            foreach (var option in dropdown.Options)
            {
                option.Click();
                var textarea = driver.FindElement(By.Id("htmlVersion"));
                Assert.That(textarea.Text, Does.Contain(option.Text));      // Fails - needs to be fixed
            }

        }
    }
}
