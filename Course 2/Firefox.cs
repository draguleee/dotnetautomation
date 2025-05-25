using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_2
{
    class Firefox
    {
        // Class variables (attributes)
        int windowWidth;

        // Method to change the window's width
        public void ChangeWindowWidth(int windowWidth)
        {
            this.windowWidth = windowWidth;
            Console.WriteLine("New window width: " + windowWidth);
        }
    }
}
