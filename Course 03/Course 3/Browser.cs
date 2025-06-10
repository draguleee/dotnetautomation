using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_3
{
    class Browser
    {
        // Class variables
        public int windowWidth_int;
        public string windowWidth_string;

        // Method to change window width (int)
        public virtual void ChangeWindowWidth(int windowWidth_int)
        {
            Console.WriteLine("Method to change the Browser's window width. To be overridden.");
        }

        // Method to change window width (string)
        public virtual void ChangeWindowWidth(string windowWidth_string)
        {
            Console.WriteLine("Method to change the Browser's window width. To be overridden.");
        }
    }
}
