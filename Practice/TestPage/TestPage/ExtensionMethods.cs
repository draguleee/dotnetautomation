using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestPage
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Fills in the text fields by clearing the existing text an entering a new one.
        /// Used for filling in the First Name and Last Name fields.
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="text"></param>
        public static void EnterText(this IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }

        /// <summary>
        /// Selects an option from the Country dropdown.
        /// If flag is true, it selects by value; otherwise it selects by text.
        /// </summary>
        /// <param name="locator"></param>
        /// <param name="flag"></param>
        /// <param name="text"></param>
        public static void SelectDropdown(this IWebElement locator, bool flag, string text)
        {
            SelectElement countries = new SelectElement(locator);
            if (flag == true)
            {
                countries.SelectByValue(text);
            }
            else
            {
                countries.SelectByText(text);
            }
        }
    }
}
