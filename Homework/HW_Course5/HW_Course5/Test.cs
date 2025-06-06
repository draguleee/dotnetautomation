using HW_Course5.Exercise1;
using HW_Course5.Exercise2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course5
{
    public class Test
    {
        static void Main(string[] args)
        {
            // Create Browser objects
            Browser_1 browser1 = new Browser_1();       // public   
            Browser_2 browser2 = new Browser_2();       // protected internal
            Browser_3 browser3 = new Browser_3();       // protected
            Browser_4 browser4 = new Browser_4();       // private
            Browser_5 browser5 = new Browser_5();       // internal
            Browser_6 browser6 = new Browser_6();       // default (private)

            // Test the SendTextToElement() visibility for every object
            browser1.SendTextToElement();
            browser2.SendTextToElement();
            // browser3.SendTextToElement();
            // browser4.SendTextToElement();
            browser5.SendTextToElement();
            // browser6.SendTextToElement();            

            Console.ReadKey();
        }
    }
}
