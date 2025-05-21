using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course1
{
    class Browser
    {

        // Class variables
        private int height;
        private int width;

        // Default constructor
        public Browser()
        {
            height = 480;
            width = 640;
        }

        // Constructor with parameters
        public Browser(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        // Method to display the height
        public int GetHeight()
        {
            return height;
        }

        // Method to display the width
        public int GetWidth()
        {
            return width;
        }

        // Method to change the window's height
        public void SetHeight(int height)
        {
            this.height = height;
        }

        // Method to change the window's width
        public void SetWidth(int width)
        {
            this.width = width;
        }

        // toString() method - displays data as a String
        public string toString()
        {
            return width + "x" + height; 
        }
    }
}
