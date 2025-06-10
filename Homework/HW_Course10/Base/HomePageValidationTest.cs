using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    [TestFixture]
    public class HomePageValidationTest : TestBase
    {
        // Method that runs before each test - overriding the base class SetUp method
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            driver.Url = "file:///C:/Users/ADragu/source/repos/dotnetautomation/Homework/HW_Course10/Base/Pages/homepage.html";
        }

        // Test to validate the title of the home page
        [Test]
        public void TestHomePageTitle()
        {
            var title = driver.Title;
            Assert.That(title, Is.EqualTo("Automation Practice Home"));
        }

        // Test to validate the header text on the home page
        [Test]
        public void TestHeaderText()
        {
            var headerText = driver.FindElement(By.XPath("//h1[contains(text(), 'Welcome')]")).Text;
            Assert.That(headerText, Does.Contain("Automation"), "Header text does not contain 'Automation'");
        }

        // Test to validate the paragraph text on the home page
        [Test]
        public void TestParagraphText()
        {
            var paragraphText = driver.FindElement(By.XPath("//p[contains(text(), 'wiki')]")).Text;
            Assert.That(paragraphText, Does.Contain("link"), "Paragraph text does not contain 'link'");
        }

        // Test to validate the link from the home page
        [Test]
        public void TestLinkToWiki()
        {
            var wikiLink = driver.FindElement(By.LinkText("Wiki Page"));
            Assert.That(wikiLink, Is.Not.Null, "Wiki link is not found on the home page");
            wikiLink.Click();
            Assert.That(driver.Url, Is.EqualTo("file:///C:/Users/ADragu/source/repos/dotnetautomation/Homework/HW_Course10/Base/Pages/WikiPage.html"));
            Assert.That(driver.Title, Is.EqualTo("Wiki Page"));
        }
    }
}
