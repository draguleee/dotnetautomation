using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Browser objects
            Browser browser = new Browser();
            browser.ChangeWindowWidth(0);

            // Create Firefox objects
            Firefox firefox = new Firefox();
            firefox.ChangeWindowWidth(1920);

            // Create Internet Explorer objects
            InternetExplorer ie = new InternetExplorer();
            ie.ChangeWindowWidth(1040);

            Console.ReadKey();
        }
    }
}
