using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_1
{
    class Browser
    {
        // Class variables (attributes)
        public int windowWidth;

        // Default constructor
        public Browser()
        {
            windowWidth = 1024;
        }

        // Constructor with parameters
        public Browser(int windowWidth)
        {
            this.windowWidth = windowWidth;
        }

        // Method to change the window's width
        public void ChangeWindowWidth(int windowWidth)
        {
            this.windowWidth = windowWidth;
            Console.WriteLine("New window width: " + this.windowWidth);
        }
    }
}
