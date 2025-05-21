using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D
{
    class InternetExplorer
    {
        // Class variables (attributes)
        private int windowWidth;

        // Constructor with parameters
        public InternetExplorer(int windowWidth)
        {
            this.windowWidth = windowWidth;
        }

        // Getter for width
        public void DisplayWindowWidth()
        {
            if (windowWidth > 1920)
            {
                int i = 0;
                while (i < 3)
                {
                    Console.WriteLine("windowWidth = " + windowWidth);
                    i++;
                }
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("windowWidth = " + windowWidth);
                }
            }
        }
    }
}
