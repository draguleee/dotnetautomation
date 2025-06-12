using NUnit.Framework;
using OpenQA.Selenium;
using page_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    /// <summary>
    /// TestIndexPage class - represents the test class for the IndexPage functionality.
    /// </summary>
    [TestFixture]
    public class TestIndexPage : TestBase
    {
        // Declare the variables used for filling textboxes
        private string name = TestData.Name;
        private string email = TestData.Email;
        private string password = TestData.Password;

        // Declare the variables used for selecting radio buttons
        private string male = TestData.Male;
        private string female = TestData.Female;
        private string other = TestData.Other;

        // Declare the variables used for selecting checkboxes
        private string coding = TestData.Coding;
        private string music = TestData.Music;
        private string traveling = TestData.Traveling;

        // Declare the variables used for fillinf the textarea
        private string bio = TestData.Bio;

        // Declare the variables used for selecting from dropdown
        private string romania = TestData.Romania;
        private string usa = TestData.USA;
        private string germany = TestData.Germany;

        /// <summary>
        /// LogIn test - fills in the form on the IndexPage and submits it.
        /// </summary>
        [Test]
        public void LogIn()
        {
            GetIndexPage().ScrollToSection(1).FillTextInputs(name, email, password).Wait(1000)
                          .ScrollToSection(2).SelectRadioButton(female).Wait(1000)
                          .ScrollToSection(3).SelectCheckbox(coding).Wait(1000)
                          .ScrollToSection(4).FillTextArea(bio)
                          .ScrollToSection(5).SelectFromDropdown(romania).Wait(1000)
                          .ScrollToSection(6).SubmitForm().Wait(1000);
        }

        /// <summary>
        /// TestWindows method - tests the window switching functionality.
        /// </summary>
        [Test]
        public void TestWindows()
        {
            string InitialWindow = GetDriver().CurrentWindowHandle;
            IReadOnlyCollection<string> windows = GetDriver().WindowHandles;
            GetDriver().SwitchTo().Window(windows.Last());
            GetDriver().SwitchTo().Window(InitialWindow);
            IWebElement frane = GetDriver().FindElement(By.CssSelector("frame[src='frame_a.html"));
            GetDriver().SwitchTo().Frame(frane);
            GetDriver().SwitchTo().DefaultContent();    
        }
    }
}
