using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course3
{
    class Browser
    {
        // Class variables
        public int windowWidth_int;
        public string windowWidth_string;

        // Method to change windowWidth_int - to be overridden
        public virtual void ChangeWindowWidth(int windowWidth_int)
        {
            this.windowWidth_int = windowWidth_int;
            Console.WriteLine("New window width for Browser (int): " + this.windowWidth_int);
        }

        // Method to display details - to be overridden
        public virtual void About()
        {
            Console.WriteLine("Browser with window width " + windowWidth_int);       
        }
    }
}
