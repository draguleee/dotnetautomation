using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1
{
    class Test
    {
        static void Main(string[] args)
        {
            // Create a Browser object with the default constructor
            Browser browser1 = new Browser();

            // Create a Browser object with the constructor with parameters
            Browser browser2 = new Browser(1920, 1080);

            // Get the width and height of the browser1 Browser object
            Console.WriteLine("\nCurrent browser1 size: ");
            Console.WriteLine(browser1.GetWidth());
            Console.WriteLine(browser1.GetHeight());

            // Get the width and height of the browser2 Browser object
            Console.WriteLine("\nCurrent browser2 size: ");
            Console.WriteLine(browser2.GetWidth());
            Console.WriteLine(browser2.GetHeight());

            // Modify the dimensions of the browser1 Browser object
            browser1.SetWidth(1600);
            browser1.SetHeight(1200);

            // Modify the dimensions of the browser2 Browser object
            browser2.SetWidth(2048);
            browser2.SetHeight(1920);

            // Print the final measurements
            Console.WriteLine("\nFinal browser sizes: ");
            Console.WriteLine("browser1 = " + browser1.toString());
            Console.WriteLine("browser2 = " + browser2.toString());

            Console.ReadKey();
        }
    }
}
