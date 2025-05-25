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
        public int windowWidth_int;
        public string windowWidth_string;
        public double windowWidth_double;

        // Method to get the windoWidth_int value
        public int GetWindowWidth()
        {
            return windowWidth_int;
        }

        // Method to set the windowWidth_int value
        public void SetWindowWidth(int windowWidth_int)
        {
            this.windowWidth_int = windowWidth_int;
        }

        // Method to display windowWidth_int
        public void DisplayWindowWidth()
        {
            if (windowWidth_int > 1920)
            {
                int i = 0;
                while (i < 3)
                {
                    Console.WriteLine("windowWidth = " + windowWidth_int);
                    i++;
                }
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("windowWidth = " + windowWidth_int);
                }
            }
        }
    }
}
