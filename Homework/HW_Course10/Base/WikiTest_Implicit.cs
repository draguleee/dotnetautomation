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
    public class WikiTest_Implicit : TestBase
    {
        // Method that runs before each test - overriding the base class SetUp method
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            driver.Url = "file:///C:/Users/ADragu/source/repos/dotnetautomation/Homework/HW_Course10/Base/Pages/homepage.html";
        }

        // Test to demonstrate implicit wait functionality
        [Test]
        public void TestImplicitWait()
        {
            var wikiLink = driver.FindElement(By.LinkText("Wiki Page"));
            Thread.Sleep(2000);     // Sleep is generally not recommended, but used here to simulate a delay before clicking the link    
            wikiLink.Click();

            var dropdownElement = driver.FindElement(By.Id("htmlSelect"));
            SelectElement dropdown = new SelectElement(dropdownElement);
            Thread.Sleep(2000);     // Sleep is generally not recommended, but used here to simulate a delay before clicking the link    

            dropdown.SelectByText("HTML5");

            var textarea = driver.FindElement(By.Id("htmlVersion"));
            Thread.Sleep(2000);     // Sleep is generally not recommended, but used here to simulate a delay before clicking the link    
            textarea.Clear();
            textarea.SendKeys("Implicit wait with sleep.");
        }
    }
}
