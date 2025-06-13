using FinalAssignmentTests.Base;
using FinalAssignmentTests.Resources;
using NUnit.Framework;

namespace FinalAssignmentTests.Tests
{
    /// <summary>
    /// TestHomePage - represents the test class for the home page.
    /// </summary>
    [TestFixture]
    public class TestHomePage : TestBaseHome
    {
        /// <summary>
        /// TestHeaderSection - tests the header section of the home page.
        /// </summary>
        [Test]
        public void TestHeader()
        {
            HomePage.CheckHeader(Commons.Header, Commons.Logo, Home.FirstLink, Home.SecondLink);
        }

        /// <summary>
        /// TestPageTitle - tests the page title of the home page.
        /// </summary>
        [Test]
        public void TestTitle()
        {
            HomePage.CheckTitle("Home");
        }

        /// <summary>
        /// TestHeadingSection - tests the heading section of the home page.
        /// </summary>
        [Test]
        public void TestHeading()
        {
            HomePage.CheckHeading("Welcome"); 
        }

        /// <summary>
        /// TestDefaultEmailPassword - tests the default email and password on the home page.   
        /// </summary>
        [Test]
        public void TestDefaultEmailPassword()
        {
            HomePage.CheckDefaultEmailPassword();
        }

        /// <summary>
        /// TestLoginFields - tests the login fields on the home page.
        /// </summary>
        [Test]
        public void TestLoginFields()
        {
            HomePage.CheckLoginFields();
        }

        /// <summary>
        /// TestLogIn - tests the login functionality on the home page.
        /// </summary>
        [Test]
        public void TestLogIn()
        {
            HomePage.LogIn("test@example.com", "password123");
        }

        /// <summary>
        /// TestWikiLink - tests the functionality of the wiki link.
        /// </summary>
        [Test]
        public void TestLink()
        {
            HomePage.CheckLink(Commons.Header, Home.SecondLink, "Selenium");
        }

        /// <summary>
        /// TestHeaderSection - tests the header section of the home page.
        /// </summary>
        [Test]
        public void TestFooter()
        {
            HomePage.CheckFooter(Commons.Footer, Commons.Privacy, Commons.Terms, Commons.Contact);
        }
    }
}
