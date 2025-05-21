using B;
using C;
using D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    class Test
    {
        static void Main(string[] args)
        {

            /* FIREFOX */

            // Create a Firefox object
            Firefox firefox = new Firefox(1920);

            // Convert the width to string
            string widthString = firefox.ConvertWidthToString(firefox.GetWindowWidth());
            double widthDouble = firefox.ConvertWidthToDouble(firefox.GetWindowWidth());
            
            // Print the converted values in the console
            Console.WriteLine("width is of type " + firefox.GetWindowWidth().GetType().Name);
            Console.WriteLine("widthString is of type " + widthString.GetType().Name);
            Console.WriteLine("widthDouble is of type " + widthDouble.GetType().Name);


            /* CHROME */

            // Create Chrome objects
            Chrome chrome1 = new Chrome(2048);
            Chrome chrome2 = new Chrome(1080);

            // Call DisplayWindowWidth() method for both objects
            chrome1.DisplayWindowWidth();
            chrome2.DisplayWindowWidth();


            /** INTERNET EXPLORER */

            // Create InternetExplorer objects
            InternetExplorer ie1 = new InternetExplorer(4096);
            InternetExplorer ie2 = new InternetExplorer(800);

            // Call DisplayWindowWidth() method for both objects
            ie1.DisplayWindowWidth();
            ie2.DisplayWindowWidth();

            Console.ReadKey();

        }
    }
}
