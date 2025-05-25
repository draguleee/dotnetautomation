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
        public int windowWidth_int = 1024;
        public string windowWidth_string;
        public double windowWidth_double;

        // Convert int to string
        public string IntToString()
        {
            windowWidth_string = Convert.ToString(windowWidth_int);
            return windowWidth_string;
        }

        // Convert string to double
        public double StringToDouble()
        {
            windowWidth_double = Convert.ToDouble(windowWidth_string);
            return windowWidth_double;
        }

        // Convert double to int
        public int DoubleToInt()
        {
            windowWidth_int = Convert.ToInt32(windowWidth_double);
            return windowWidth_int;
        }
    }
}
