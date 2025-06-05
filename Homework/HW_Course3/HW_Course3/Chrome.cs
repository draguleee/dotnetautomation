using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course3
{
    class Chrome : Browser
    {
        // Override the method for changing the windowWidth_string
        public void ChangeWindowWidth(string windowWidth_string)
        {
            base.windowWidth_string = windowWidth_string;
            Console.WriteLine("New window width for Chrome (string): " + windowWidth_string);
        }

        // Override the method for changing the windowWidth_int
        public override void ChangeWindowWidth(int windowWidth_int)
        {
            base.windowWidth_int = windowWidth_int;
            Console.WriteLine("New window width for Chrome (int): " + windowWidth_int);
        }        

        // Override the About() method
        public override void About()
        {
            Console.WriteLine("Chrome with window width " + windowWidth_int + " ('" + windowWidth_string + "')");
        }
    }
}
