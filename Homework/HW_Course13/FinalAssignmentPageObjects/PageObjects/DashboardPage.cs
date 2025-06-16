using FinalAssignmentPageObjects.Base;
using FinalAssignmentPageObjects.Resources;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FinalAssignmentPageObjects.PageObjects
{
    /// <summary>
    /// DashboardPage - represents the dashboard page of the application.
    /// </summary>
    public class DashboardPage : PageBase
    {
        /// <summary>
        /// DashboardPage constructor - initializes the driver and waits for elements.
        /// </summary>
        /// <param name="driver"></param>
        public DashboardPage(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// EditPersonalInformation method - edits the personal information of the user.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="biography"></param>
        /// <returns></returns>
        public DashboardPage EditPersonalInformation(string name, string biography)
        {
            var form = Wait.Until(d => d.FindElement(By.Id(Dashboard.Form)));

            var fullName = form.FindElement(By.Id(Dashboard.Name));
            var bio = form.FindElement(By.Id(Dashboard.Bio));

            fullName.Clear();
            bio.Clear();

            fullName.SendKeys(name);
            bio.SendKeys(biography);

            var save = form.FindElement(By.TagName(Dashboard.Save));
            save.Click();

            if (fullName.GetAttribute("value") == "" && bio.GetAttribute("value") == "")
            {
                Assert.Fail(Errors.EmptyError);
            }
            else if (fullName.GetAttribute("value") == "")
            {
                Assert.Fail(Errors.NameError);
            }
            else if (bio.GetAttribute("value") == "")
            {
                Assert.Fail(Errors.BioError);
            }
            else
            {
                Assert.Pass(Dashboard.Saved);
            }

            return this;
        }

        /// <summary>
        /// Logout method - logs the user out of the dashboard.
        /// </summary>
        /// <returns></returns>
        public DashboardPage Logout()
        {
            var logout = Wait.Until(d => d.FindElement(By.Id(Dashboard.Logout)));
            logout.Click();
            Assert.That(Driver.Title, Does.Contain("Home"), Errors.LogoutFailedError);
            return this;
        }
    }
}
