using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_2
{
    class Test
    {
        static void Main(string[] args)
        {
            // Define value?
            int value = 8 / 2;

            // Defining & Initializing variables
            short a = 10;
            int b = 20;
            double c = a + b;

            // float + double + decimal
            Console.WriteLine("\nFLOAT DOUBLE DECIMAL");
            float a1 = 0.123456789123456789F;                       // float: 7 digits (32-bit)
            double a2 = 0.123456789123456789D;                      // double: 15-16 digits (64-bit)
            decimal a3 = 0.123456789123456789123456789123456789M;   // decimal: 28-29 digits (128-bit)
            Console.WriteLine("Float value: " + a1 + "F");
            Console.WriteLine("Double value: " + a2 + "D");  
            Console.WriteLine("Decimal value: " + a3 + "M");

            // var data type
            Console.WriteLine("\nVAR DATA TYPE");
            string text1 = "This is a string type.";
            var text2 = "This is also a string type.";
            Console.WriteLine(text1);
            Console.WriteLine(text2);

            // Converting variables
            Console.WriteLine("\nCONVERTING VARIABLES");
            Console.WriteLine(Convert.ToString(a));
            Console.WriteLine(Convert.ToDouble(b));
            Console.WriteLine(Convert.ToDecimal(c));

            // Operators
            Console.WriteLine("\nOPERATORS");
            double x = 7;
            double y = 3;
            Console.WriteLine(x + " + " + y + " = " + (x + y));   // Sum
            Console.WriteLine(x + " - " + y + " = " + (x - y));   // Difference
            Console.WriteLine(x + " * " + y + " = " + (x * y));   // Product
            Console.WriteLine(x + " / " + y + " = " + (x / y));   // Division
            Console.WriteLine(x + " % " + y + " = " + (x % y));   // Remainder

            // Pre + Post Increment
            Console.WriteLine("\nPRE & POST INCREMENTS");
            int o1 = 10;
            Console.WriteLine(o1++);        // 10
            Console.WriteLine(o1);          // 11
            int o2 = 10;
            Console.WriteLine(++o2);        // 11
            Console.WriteLine(o2);          // 11

            // Assignment Operators
            Console.WriteLine("\nASSIGNMENT OPERATORS");
            Console.WriteLine("C = A + B <-> A + B = C");
            Console.WriteLine("C += A <-> C = C + A");
            Console.WriteLine("C -= A <-> C = C - A");
            Console.WriteLine("C *= A <-> C = C * A");
            Console.WriteLine("C /= A <-> C = C / A");

            // If
            Console.WriteLine("\nIF");
            if (value == 4)
            {
                Console.WriteLine("true");
            }

            // If-Else
            Console.WriteLine("\nIF-ELSE");
            if (value == 4)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            // If-Else-If
            Console.WriteLine("\nSWITCH");
            if (value == 4)
            {
                Console.WriteLine("value == 4");
            }
            else if (value < 4)
            {
                Console.WriteLine("value < 4");
            }
            else
            {
                Console.WriteLine("value > 4");
            }

            // Switch-Case
            Console.WriteLine("\nSWITCH-CASE");
            switch(value)
            {
                case 1: Console.WriteLine("value == 1"); break;
                case 4: Console.WriteLine("value == 4"); break;
                default: Console.WriteLine("Unknown value"); break;
            }

            // While 
            Console.WriteLine("\nWHILE LOOP");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // For
            Console.WriteLine("\nFOR LOOP");
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }

            // Do-While
            Console.WriteLine("\nDO-WHILE");
            int k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            }
            while (i < 4);

            // UML Basic Class
            Console.WriteLine("\nUML BASIC CLASS");
            Shape shape = new Shape();
            shape.SetLength(10);
            Console.WriteLine("Shape's length: " + shape.GetLength());
            Firefox firefox = new Firefox();
            firefox.ChangeWindowWidth(1920);


            Console.ReadKey();
        }
    }
}
