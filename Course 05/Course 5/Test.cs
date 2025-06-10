using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_5
{
    class Test
    {
        static void Main(string[] args)
        {
            // Create the Math object, then call the Division() method with divisor 0
            Math operation = new Math();
            operation.Division(2, 0);

            // Test the access modifiers methods
            AccessModifiers am = new AccessModifiers();
            am.TestPublic();
            am.TestInternal();
            // am.TestProtected();
            am.TestInternalProtected();
            // am.TestPrivate();
            // am.TestDefaultPrivate();

            // Static keyword
            // Cannot create instances of static classes!
            StaticClass.Number = 10;
            StaticClass.DisplayNumber();

            Console.ReadKey();
        }
    }
}
