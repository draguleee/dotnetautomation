using A;
using B;
using C;
using D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course2
{
    class Test
    {
        static void Main(string[] args)
        {
            // Browser class
            Console.WriteLine("\nBROWSER");
            Browser browser = new Browser();
            browser.windowWidth_int = 1920;
            browser.windowWidth_string = "1920";
            browser.windowWidth_double = 1920D;
            Console.WriteLine("windowWidth_int: " + browser.windowWidth_int);
            Console.WriteLine("windowWidth_string: " + browser.windowWidth_string);
            Console.WriteLine("windowWidth_double: " + browser.windowWidth_double);

            // Firefox
            Console.WriteLine("\nFIREFOX");
            Firefox firefox = new Firefox();
            Console.WriteLine("Converted int to string: " + firefox.IntToString());
            Console.WriteLine("Converted string to double: " + firefox.StringToDouble());
            Console.WriteLine("Converted double to int: " + firefox.DoubleToInt());

            // Chrome
            Console.WriteLine("\nCHROME");
            Chrome chrome1 = new Chrome();
            Chrome chrome2 = new Chrome();
            chrome1.SetWindowWidth(1024);
            chrome2.SetWindowWidth(1920);
            chrome1.DisplayWindowWidth();
            chrome2.DisplayWindowWidth();

            // InternetExplorer
            InternetExplorer ie1 = new InternetExplorer();
            InternetExplorer ie2 = new InternetExplorer();
            ie1.SetWindowWidth(1400);
            ie2.SetWindowWidth(2048);
            ie1.DisplayWindowWidth();
            ie2.DisplayWindowWidth();

            Console.ReadKey();
        }
    }
}
