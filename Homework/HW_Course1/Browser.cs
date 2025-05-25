using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course1
{
    class Browser
    {
        // Class variables
        int height;
        int width;

        // Constructor with parameters
        public Browser(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        // Method to display the height 
        public void DisplayWindowHeight()
        {
            Console.WriteLine("Window height: " + height);
        }

        // Method to display the width
        public void DisplayWindowWidth()
        {
            Console.WriteLine("Window width: " + width);
        }

        // Method to change window height
        public void ChangeWindowHeight(int height)
        {
            this.height = height;
            Console.WriteLine("New window height: " + this.height);
        }

        // Method to change window width
        public void ChangeWindowWidth(int width)
        {
            this.width = width;
            Console.WriteLine("New window width: " + this.width);
        }
    }
}
