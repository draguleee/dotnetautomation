using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_4
{
    class Firefox : Browser, IComponent
    {
        // Provide implementation for the ChangeWindowWidth method
        public override void ChangeWindowWidth(int newWindowWidth)
        {
            int windowWidth = base.WindowWidth;
            windowWidth = newWindowWidth;
            Console.WriteLine("New window width for Firefox: " + windowWidth);
        }

        // Provide implementation for the About() method
        public void About()
        {
            Console.WriteLine("This is the Firefox browser.");
        }
    }
}
