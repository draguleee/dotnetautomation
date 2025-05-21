using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Firefox
    {

        // Class variables (attributes)
        private int windowWidth;

        // Constructor with parameters
        public Firefox(int windowWidth) 
        { 
            this.windowWidth = windowWidth;
        }

        // Getter for width
        public int GetWindowWidth()
        {
            return windowWidth;
        }

        // Method to convert the windowWidth to string
        public string ConvertWidthToString(int windowWidth)
        {
            return Convert.ToString(windowWidth);
        }

        // Method to convert the windowWidth to double
        public double ConvertWidthToDouble(int windowWidth)
        {
            return Convert.ToDouble(windowWidth);
        }
    }
}
