using FinalAssignmentPageObjects.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAssignmentTests.Base
{
    /// <summary>
    /// TestBaseDashboard - represents the base class for dashboard tests.
    /// </summary>
    public class TestBaseDashboard : TestBase
    {
        // Declare the DashboardPage object
        protected DashboardPage DashboardPage { get; set; }

        /// <summary>
        /// SetUp method - runs before each test in this class.
        /// </summary>
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
            Driver.Url = "C:\\Users\\aandr\\source\\repos\\dotnetautomation\\Homework\\HW_Course12\\FinalAssignmentPageObjects\\.Pages\\dashboard.html";
            DashboardPage = new DashboardPage(Driver);
        }
    }
}
