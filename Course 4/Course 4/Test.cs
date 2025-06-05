using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_4
{
    class Test
    {
        static void Main(string[] args)
        {
            // Create Firefox object
            Firefox firefox = new Firefox();
            firefox.WindowWidth = 1920;
            Console.WriteLine(firefox.WindowWidth);
            // firefox.SetWindowWidth(1920);
            // Console.WriteLine(firefox.GetWindowWidth());
            firefox.About();

            // Create Chrome object
            Chrome chrome = new Chrome();
            chrome.WindowWidth = 1080;
            Console.WriteLine(chrome.WindowWidth);
            // chrome.SetWindowWidth(1080);
            // Console.WriteLine(chrome.GetWindowWidth());
            chrome.About();

            Console.ReadKey();
        }
    }
}
