using FinalAssignmentPageObjects.PageObjects;
using NUnit.Framework;

namespace FinalAssignmentTests.Base
{
    /// <summary>
    /// TestBaseHome - represents the base class for home page tests.
    /// </summary>
    [TestFixture]
    public class TestBaseHome : TestBase
    {
        // Declare the  HomePage object
        protected HomePage HomePage { get; set; }

        /// <summary>
        /// SetUp - runs before each test in this class.
        /// </summary>
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            Driver.Url = "C:\\Users\\aandr\\source\\repos\\dotnetautomation\\Homework\\HW_Course12\\FinalAssignmentPageObjects\\.Pages\\home.html";
            HomePage = new HomePage(Driver);
        }
    }
}
