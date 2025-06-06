using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course6.Exercise2
{
    public class HomePage
    {
        // Create string variables for the specific xPaths
        public string imageHeader = "//a[@class='custom-logo-link']/img";
        public string homeLinkHeader = "//div[@id='site-title']";
        public string title = "//h2[text()='Test login']";
        public string text = "//li[contains(text(),'LogIn')]";
        public string credentials = "//li[contains(text(), 'credentials')]";
        public string username = "//input[@id='username']";
        public string password = "//input[@id='password']";
        public string submit = "//button[@id='submit']";

        // Method to display the xPaths
        public void DisplayXPaths()
        {
            Console.WriteLine("Image Header XPath: " + imageHeader);
            Console.WriteLine("Home Link Header XPath: " + homeLinkHeader);
            Console.WriteLine("Title XPath: " + title);
            Console.WriteLine("Text XPath: " + text);
            Console.WriteLine("Credentials XPath: " + credentials);
            Console.WriteLine("Username XPath: " + username);
            Console.WriteLine("Password XPath: " + password);
            Console.WriteLine("Submit Button XPath: " + submit);
        }
    }
}
