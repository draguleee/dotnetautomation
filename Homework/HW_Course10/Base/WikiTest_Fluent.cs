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
    public class WikiTest_Fluent : TestBase
    {
        // Method that runs before each test - overriding the base class SetUp method
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            driver.Url = "file:///C:/Users/ADragu/source/repos/dotnetautomation/Homework/HW_Course10/Base/Pages/homepage.html";
        }

        // Test to demonstrate fluent wait functionality
        [Test]
        public void TestFluentWait()
        {
            var wikiLink = Browser.FluentWait(driver, By.LinkText("Wiki Page"), 10);
            Thread.Sleep(2000);     // Sleep is generally not recommended, but used here to simulate a delay before clicking the link    
            wikiLink.Click();

            var dropdownElement = Browser.FluentWait(driver, By.Id("htmlSelect"), 10);
            SelectElement dropdown = new SelectElement(dropdownElement);
            Thread.Sleep(2000);     // Sleep is generally not recommended, but used here to simulate a delay before clicking the link    
            dropdown.SelectByText("HTML5");

            var textarea = Browser.FluentWait(driver, By.Id("htmlVersion"), 10);
            Thread.Sleep(2000);     // Sleep is generally not recommended, but used here to simulate a delay before clicking the link    
            textarea.Clear();
            textarea.SendKeys("Fluent wait with sleep.");
        }
    }
}
