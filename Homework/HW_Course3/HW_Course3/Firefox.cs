using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course3
{
    class Firefox : Browser
    {
        // Method to set a profile for Firefox 
        public void SetProfile(string profileName)
        {
            Console.WriteLine("Firefox profile: " + profileName);
        }

        // Override the method for changing the windowWidth_int
        public override void ChangeWindowWidth(int windowWidth_int)
        {
            base.windowWidth_int = windowWidth_int;
            Console.WriteLine("New window width for Firefox (int): " + windowWidth_int);
        }

        // Override the About() method
        public override void About()
        {
            Console.WriteLine("Firefox with window width " + windowWidth_int);
        }
    }
}
