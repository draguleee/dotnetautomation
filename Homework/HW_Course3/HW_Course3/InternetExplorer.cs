using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course3
{
    class InternetExplorer : Browser
    {
        // Override the method for changing the windowWidth_int
        public override void ChangeWindowWidth(int windowWidth_int)
        {
            base.windowWidth_int = windowWidth_int;
            Console.WriteLine("New window width for Interner Explorer (int): " + windowWidth_int);
        }

        // Override the About() method
        public override void About()
        {
            Console.WriteLine("Internet Explorer with width " + windowWidth_int);
        }
    }
}
