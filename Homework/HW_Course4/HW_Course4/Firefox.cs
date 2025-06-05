using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course4
{
    class Firefox : Browser, IComponent, INetwork
    {
        // Provide implementation for StartBrowser() method
        public override void StartBrowser()
        {
            Console.WriteLine("Firefox browser has been started.");
        }

        // Provide implementation for About() method
        public void About()
        {
            Console.WriteLine("This is Firefox browser. \nWindow width: " + base.WindowWidth);
        }

        // Provide implementation for Ping() method
        public void Ping()
        {
            Console.WriteLine("Firefox browser is running.");
        }
    }
}
