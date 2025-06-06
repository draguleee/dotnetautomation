using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsideAssembly
{
    class Test
    {
        static void Main(string[] args)
        {
            AccessModifiersOutsideAssembly amoa = new AccessModifiersOutsideAssembly();
            amoa.TestAccess();
        }
    }
}
