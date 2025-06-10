using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_3
{
    class InternetExplorer : Browser
    {
        // Overridden method (for int value)
        public override void ChangeWindowWidth(int windowWidth_int)
        {
            base.windowWidth_int = windowWidth_int;
            Console.WriteLine("New window width for Internet Explorer (int): " + windowWidth_int);
        }

        // Overridden method (for string value)
        public override void ChangeWindowWidth(string windowWidth_string)
        {
            base.windowWidth_string = windowWidth_string;
            Console.WriteLine("New window width for Internet Explorer (string): " + windowWidth_string);
        }
    }
}
