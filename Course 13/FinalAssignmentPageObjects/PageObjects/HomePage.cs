using FinalAssignmentPageObjects.Base;
using FinalAssignmentPageObjects.Resources;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FinalAssignmentPageObjects.PageObjects
{
    /// <summary>
    /// HomPage - represents the home page of the application.
    /// </summary>
    public class HomePage : PageBase
    {
        /// <summary>
        /// HomePage constructor - initializes the driver and waits for elements.
        /// </summary>
        /// <param name="driver"></param>
        public HomePage(IWebDriver driver) : base(driver) { }

        /// <summary>
        /// CheckDefaultEmailPassword method - checks the default email and password in the form section.
        /// </summary>
        /// <returns></returns>
        public HomePage CheckDefaultEmailPassword()
        {
            var form = Wait.Until(d => d.FindElement(By.Id(Home.Form)));

            var emailText = form.FindElement(By.Id(Home.Email)).GetAttribute("value");
            Assert.That(emailText, Is.EqualTo(Home.DefaultEmail), Errors.DefaultEmailError);

            var passwordText = form.FindElement(By.Id(Home.Password)).GetAttribute("value");
            Assert.That(passwordText, Is.EqualTo(Home.DefaultPassword), Errors.DefaultPasswordError);

            return this;
        }

        /// <summary>
        /// CheckLoginFields method - checks if the login fields are displayed on the home page.
        /// </summary>
        /// <returns></returns>
        public HomePage CheckLoginFields()
        {
            var form = Wait.Until(d => d.FindElement(By.Id(Home.Form)));

            var emailField = form.FindElement(By.Id(Home.Email));
            Assert.That(emailField.Displayed, Is.True, Errors.EmailFieldError);

            var passwordField = form.FindElement(By.Id(Home.Password));
            Assert.That(passwordField.Displayed, Is.True, Errors.PasswordFieldError);

            var loginButton = form.FindElement(By.XPath(Home.Login));
            Assert.That(loginButton.Displayed, Is.True, Errors.LoginButtonError);

            return this;
        }

        /// <summary>
        /// LogIn method - logs the user into the dashboard.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public HomePage LogIn(string email, string password)
        {
            var form = Wait.Until(d => d.FindElement(By.Id(Home.Form)));

            var emailField = form.FindElement(By.Id(Home.Email));
            var passwordField = form.FindElement(By.Id(Home.Password));
            var loginButton = form.FindElement(By.TagName(Home.Login));

            emailField.Clear();
            passwordField.Clear();  

            emailField.SendKeys(email);
            passwordField.SendKeys(password);

            loginButton.Click();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                var errorMessage = form.FindElement(By.Id(Home.NullText));
                Assert.That(errorMessage.Text, Is.EqualTo(Errors.NullEmailAddressError), Errors.NullEmailAddressError);
            }
            else if (!email.Contains("@"))
            {
                var errorMessage = form.FindElement(By.Id(Home.FormatText));
                Assert.That(errorMessage.Text, Is.EqualTo(Errors.InvalidEmailFormatError), Errors.InvalidEmailFormatError);
            }
            else if (email != Home.DefaultEmail || password != Home.DefaultPassword)
            {
                var errorMessage = form.FindElement(By.Id(Home.InvalidText));
                Assert.That(errorMessage.Text, Is.EqualTo(Errors.InvalidCredentialsError), Errors.InvalidCredentialsError);
            } else
            {
                Wait.Until(d => d.Title.Contains("Dashboard"));
                Assert.That(Driver.Title, Does.Contain("Dashboard"), Errors.LoginFailedError);
            }

            return this;
        }
    }
}
