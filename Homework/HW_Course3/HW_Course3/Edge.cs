using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course3
{
    class Edge : InternetExplorer
    {
        // Class variables
        public int version;

        // Method to display the new feature
        public void NewFeatureFunction()
        {
            Console.WriteLine("Enhanced functionality and bugfixes for Microsoft Edge.");
        }

        // Override the method for changing the windowWidth_int
        public override void ChangeWindowWidth(int windowWidth_int)
        {
            base.windowWidth_int = windowWidth_int;
            Console.WriteLine("New window width for Edge (int): " + windowWidth_int);
        }

        // Override the About() method
        public override void About()
        {
            Console.WriteLine("Edge with window width " + windowWidth_int);
        }
    }
}
