using FinalAssignmentPageObjects.Resources;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace FinalAssignmentPageObjects.Base
{
    /// <summary>
    /// PageBase - represents the base class for all page objects in the application.
    /// </summary>
    public abstract class PageBase
    {
        // Create instances of IWebElement and wait
        protected IWebDriver Driver { get; }
        protected WebDriverWait Wait { get; }

        /// <summary>
        /// PageBase constructor - initializes the driver and wait instances.
        /// </summary>
        /// <param name="driver"></param>
        protected PageBase(IWebDriver driver)
        {
            Driver = driver;
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        /// <summary>
        /// CheckHeader method - checks the header section of the page.
        /// </summary>
        /// <param name="headerTag"></param>
        /// <param name="imageId"></param>
        /// <param name="link1"></param>
        /// <param name="link2"></param>
        /// <returns></returns>
        public PageBase CheckHeader(string headerTag, string imageId, string link1, string link2)
        {
            var header = Wait.Until(d => d.FindElement(By.TagName(headerTag)));

            var image = header.FindElement(By.Id(imageId));
            Assert.That(image.Displayed, Is.True, Errors.LogoError);

            var firstLink = header.FindElement(By.Id(link1));
            Assert.That(firstLink.Displayed, Is.True, Errors.FirstLinkError);

            var secondLink = header.FindElement(By.Id(link2));
            Assert.That(secondLink.Displayed, Is.True, Errors.SecondLinkError);

            return this;
        }

        /// <summary>
        /// CheckPageTitle method - checks the page title of the current page.
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public PageBase CheckTitle(string title)
        {
            var pageTitle = Driver.Title;
            Assert.That(pageTitle, Does.Contain(title), string.Format(Errors.TitleError, GetType().Name, title));
            return this;
        }

        /// <summary>
        /// CheckHeading method - checks the heading section of the page.
        /// </summary>
        /// <param name="contains"></param>
        /// <returns></returns>
        public PageBase CheckHeading(string contains)
        {
            var heading = Wait.Until(d => d.FindElement(By.XPath("//h1[contains(text(), '" + contains + "')]")));
            Assert.That(heading.Text, Does.Contain(contains), string.Format(Errors.HeadingError, contains));
            return this;

        }

        /// <summary>
        /// CheckLink method - checks if a specific link is present on the page.
        /// </summary>
        /// <returns></returns>
        public PageBase CheckLink(string headerTag, string linkId, string url)
        {
            var header = Wait.Until(d => d.FindElement(By.TagName(headerTag)));

            var link = header.FindElement(By.Id(linkId));
            link.Click();
            Assert.That(Driver.Title, Does.Contain(url), Errors.RedirectError);
            
            return this;
        }

        /// <summary>
        /// CheckFooter method - checks the footer section of the page for specific links.
        /// </summary>
        /// <param name="footerTag"></param>
        /// <param name="privacy"></param>
        /// <param name="terms"></param>
        /// <param name="contact"></param>
        /// <returns></returns>
        public PageBase CheckFooter(string footerTag, string privacy, string terms, string contact)
        {
            var footer = Wait.Until(d => d.FindElement(By.TagName(footerTag)));

            var privacyLink = footer.FindElement(By.XPath(privacy));
            Assert.That(privacyLink.Displayed, Errors.PrivacyLinkError);

            var termsLink = footer.FindElement(By.XPath(terms));
            Assert.That(termsLink.Displayed, Errors.TermsLinkError);

            var contactLink = footer.FindElement(By.XPath(contact));
            Assert.That(contactLink.Displayed, Errors.ContactLinkError);

            return this;
        }
    }
}
