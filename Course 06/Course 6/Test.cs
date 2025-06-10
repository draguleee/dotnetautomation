using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_6
{
    class Test
    {
        // Default values for data types
        static bool defaultBool;
        static byte defaultByte;
        static char defaultChar;
        static decimal defaultDecimal;
        static double defaultDouble;
        static float defaultFloat;
        static int defaultInt;
        static long defaultLong;
        static sbyte defaultSByte;
        static short defaultShort;
        static string defaultString;
        static uint defaultUInt;
        static ulong defaultULong;
        static ushort defaultUShort;

        static void Main(string[] args)
        {
            // Display the default values of the data types
            Console.WriteLine("Default values of data types in C#:");
            Console.WriteLine("Default bool: " + defaultBool);
            Console.WriteLine("Default byte: " + defaultByte);
            Console.WriteLine("Default char: " + defaultChar);
            Console.WriteLine("Default decimal: " + defaultDecimal);
            Console.WriteLine("Default double: " + defaultDouble);
            Console.WriteLine("Default float: " + defaultFloat);
            Console.WriteLine("Default int: " + defaultInt);
            Console.WriteLine("Default long: " + defaultLong);
            Console.WriteLine("Default sbyte: " + defaultSByte);
            Console.WriteLine("Default short: " + defaultShort);
            Console.WriteLine("Default string: " + defaultString);
            Console.WriteLine("Default uint: " + defaultUInt);
            Console.WriteLine("Default ulong: " + defaultULong);
            Console.WriteLine("Default ushort: " + defaultUShort);

            // Create a Browser object and call its methods
            Console.WriteLine("\nMethods");
            RunTests runTests = new RunTests();
            Browser browser = new Browser();
            runTests.RunBrowserTests(browser);
            browser.NoReturnNoParameters();
            browser.NoReturnWithParameters(1080);   
            browser.WithReturnNoParameters();
            browser.WithReturnWithParameters(720);

            // Arrays
            Console.WriteLine("\nArrays");
            string[] browsers = { "Chrome", "Firefox", "Edge", "Safari" };
            Console.WriteLine("Available browsers:");
            Console.WriteLine(browsers[0]);     // Chrome
            Console.WriteLine(browsers[1]);     // Firefox
            Console.WriteLine(browsers[2]);     // Edge
            Console.WriteLine(browsers[3]);     // Safari
            // Console.WriteLine(browsers[4]);  // Index out of bounds 

            // For loop
            Console.WriteLine("\nFor Loop");
            for (int i = 0; i < browsers.Length; i++)
            {
                Console.WriteLine(browsers[i]);
            }

            // Foreach loop
            Console.WriteLine("\nForeach Loop");
            foreach (var browserName in browsers)
            {
                Console.WriteLine(browserName);
            }

            // Lists
            Console.WriteLine("\nLists");
            List<string> browserList = new List<string> { "Chrome", "Firefox", "Edge", "Safari" };
            browserList.Add("Opera");
            browserList.Remove("Edge");
            foreach (var item in browserList)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}