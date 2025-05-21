using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class Chrome
    {
        // Class variables (attributes)
        private int windowWidth;

        // Constructor with parameters
        public Chrome(int windowWidth)
        {
            this.windowWidth = windowWidth;
        }

        // Getter for width
        public void DisplayWindowWidth()
        {
            if (windowWidth >= 1920)
            {
                Console.WriteLine("windowWidth = " + windowWidth);
            }
            else
            {
                Console.WriteLine("windowWidth is less than 1920.");
            }
        }
    }
}
