using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_6
{
    class Browser
    {
        // Method without parameters and without return type
        public void NoReturnNoParameters()
        {
            Console.WriteLine("This method has no parameters and does not return a value.");
        }

        // Method with parameters and without return type
        public void NoReturnWithParameters(int resolution)
        {
            Console.WriteLine("No return, with resolution: " + resolution);
        }

        // Method without parameters and with return type
        public string WithReturnNoParameters()
        {
            return "This method has no parameters but returns a string value.";
        }

        // Method with parameters and with return type
        public string WithReturnWithParameters(int resolution)
        {
            return resolution > 1080 ? "High resolution" : "Low resolution";
        }
    }
}
