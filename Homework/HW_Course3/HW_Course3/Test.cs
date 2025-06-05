using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course3
{
    class Test
    {
        static void Main(string[] args)
        {
            // Create Browser object
            Console.WriteLine();
            Browser browser = new Browser();
            browser.ChangeWindowWidth(1920);
            browser.About();

            // Create Firefox object
            Console.WriteLine();
            Firefox firefox = new Firefox();
            firefox.SetProfile("Andre");
            firefox.ChangeWindowWidth(2048);
            firefox.About();

            // Create Chrome object
            Console.WriteLine();
            Chrome chrome = new Chrome();
            chrome.ChangeWindowWidth("1024");
            chrome.ChangeWindowWidth(1024);
            chrome.About();

            // Create InternetExplorer object
            Console.WriteLine();
            InternetExplorer ie = new InternetExplorer();
            ie.ChangeWindowWidth(1800);
            ie.About();

            // Create Edge object
            Console.WriteLine();
            Edge edge = new Edge();
            edge.NewFeatureFunction();
            edge.ChangeWindowWidth(600);
            edge.About();

            Console.ReadKey();
            
        }
    }
}
