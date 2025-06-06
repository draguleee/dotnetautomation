using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibTraining
{
    [TestFixture]
    public class Test
    {
        // Create a Browser object
        Browser browser = new Browser();

        // Test to check if the browser starts successfully
        [Test]
        public void TestStartBrowser()
        {
            bool result = browser.StartBrowser();
            Assert.That(result, Is.True);
        }

        // Test to check if the browser is stopped
        [Test]
        public void TestStopBrowser()
        {
            bool result = !browser.StartBrowser();
            Assert.That(result, Is.False);
        }

        // Test to check if the retrieved page title is the same with the expected
        [Test]
        public void TestGetPageTitleEquals()
        {
            string title = browser.GetPageTitle();
            Assert.That(title, Is.EqualTo("Browser Page Title"));
        }

        // Test to check if the retrieved page title contains a keyword
        [Test]
        public void TestGetPageTitleContains()
        {
            string title = browser.GetPageTitle();
            Assert.That(title, Does.Contain("Browser"));
        }

        // Test to check if the browser's width is equal to the expected
        [Test]
        public void TestGetBrowserWidthEquals()
        {
            int width = browser.GetBrowserWidth();
            Assert.That(width, Is.EqualTo(1080));
        }

        // Test to check if the browser's width is greater than a certain value
        [Test]
        public void TestGetBrowserWidthGreaterThan()
        {
            int width = browser.GetBrowserWidth();
            Assert.That(width, Is.GreaterThan(800));
        }

        // Test to check if the browser's width is less than a certain value
        [Test]
        public void TestGetBrowserWidthLessThan()
        {
            int width = browser.GetBrowserWidth();
            Assert.That(width, Is.LessThan(1200));
        }
    }
}
