using Course_11.PageObjects;
using Course_11.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Reflection;


namespace Course_11.Base
{
    public class TestBaseIndex : TestBase
    {
        // Create an instance of the IndexPage class
        public IndexPage index;

        // Method that runs before each test    
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            driver.Url = "C:\\Users\\ADragu\\source\\repos\\dotnetautomation\\Course 11\\Course 11\\Pages\\index.html";
            index = new IndexPage(driver);
        }
    }
}
