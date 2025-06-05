using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course4
{
    class Skype : IComponent, INetwork
    {
        // Provide implementation for About() method
        public void About()
        {
            Console.WriteLine("Skype application has been started.");
        }

        // Provide implementation for Ping() method
        public void Ping()
        {
            Console.WriteLine("Skype application is running.");
        }
    }
}
