using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course1
{
    class Test
    {
        static void Main(string[] args)
        {
            // Create a Browser object
            Browser browser = new Browser(400, 600);

            // Display the current window 
            browser.DisplayWindowHeight();
            browser.DisplayWindowWidth();

            // Change the window height and width
            browser.ChangeWindowHeight(1080);
            browser.ChangeWindowWidth(1920);

            Console.ReadKey();
        }
    }
}
