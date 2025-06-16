using FinalAssignmentPageObjects.PageObjects;
using FinalAssignmentTests.Base;
using FinalAssignmentTests.Resources;
using FinalAssignmentUtils;
using NUnit.Framework;

namespace FinalAssignmentTests.Tests
{
    /// <summary>
    /// TextDashboardPage - represents the test class for the dashboard page.
    /// </summary>
    [TestFixture]
    public class TestDashboardPage : TestBaseDashboard
    {
        /// <summary>
        /// TestHeaderSection - tests the header section of the dashboard page.
        /// </summary>
        [Test]
        public void TestHeader()
        {
            DashboardPage.CheckHeader(Commons.Header, Commons.Logo, Dashboard.FirstLink, Dashboard.SecondLink);
            string path = ScreenshotHelper.CaptureScreen(Driver);
        }

        /// <summary>
        /// TestPageTitle - tests the page title of the dashboard page.
        /// </summary>
        [Test]
        public void TestTitle()
        {
            DashboardPage.CheckTitle("Dashboard");
            string path = ScreenshotHelper.CaptureScreen(Driver);
        }

        /// <summary>
        /// TestHeading - tests the heading section of the dashboard page.
        /// </summary>
        [Test]
        public void TestHeading()
        {
            DashboardPage.CheckHeading("Dashboard");
            string path = ScreenshotHelper.CaptureScreen(Driver);
        }

        /// <summary>
        /// TestDetails - tests the personal information editing functionality on the dashboard page.   
        /// </summary>
        [Test]  
        public void TestDetails()
        {
            DashboardPage.EditPersonalInformation("Andre Dragu", "Test Bio.");
            string path = ScreenshotHelper.CaptureScreen(Driver);
        }

        /// <summary>
        /// TestLogout - tests the logout functionality on the dashboard page.
        /// </summary>
        [Test]
        public void TestLogout()
        {
            DashboardPage.Logout();
            string path = ScreenshotHelper.CaptureScreen(Driver);
        }

        /// <summary>
        /// TestFooter - tests the footer section of the dashboard page.
        /// </summary>
        [Test]
        public void TestFooter()
        {
            DashboardPage.CheckFooter(Commons.Footer, Commons.Privacy, Commons.Terms, Commons.Contact);
            string path = ScreenshotHelper.CaptureScreen(Driver);
        }
    }
}
