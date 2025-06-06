using NUnit.Framework;

namespace ClassLibTraining
{
    public class Browser
    {
        // Class variable
        private int browserWidth = 1080;

        // Method to start the browser
        public bool StartBrowser()
        {
            Console.WriteLine("Browser started successfully.");
            return true;
        }

        // Method to get the page's title
        public string GetPageTitle()
        {
            return "Browser Page Title";
        }

        // Method to get the browser width
        public int GetBrowserWidth()
        {
            return browserWidth;
        }
    }
}
