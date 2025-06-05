using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course4
{
    class Test
    {
        static void Main(string[] args)
        {
            // Create Firefox object
            Console.WriteLine();
            Firefox firefox = new Firefox();
            firefox.WindowWidth = 2048;
            firefox.WindowWidth = 1800;
            firefox.StartBrowser();
            firefox.About();
            firefox.Ping();

            // Create Skype object
            Console.WriteLine();
            Skype skype = new Skype();
            skype.About();
            skype.Ping();   

            Console.ReadKey();
        }
    }
}
