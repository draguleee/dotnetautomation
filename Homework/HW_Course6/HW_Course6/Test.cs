using HW_Course6.Exercise1;
using HW_Course6.Exercise2;
using HW_Course6.Exercise3;
using System;

namespace HW_Course6
{
    public class Test
    {
        static void Main(string[] args)
        {
            // EXERCISE 1
            Console.WriteLine("Exercise 1: Creating Firefox objects and displaying window width");

            // Declare a local variable to store the value returned by GetWindowWidth() method
            int windowWidth;

            // Create Firefox object using default constructor
            Firefox firefox1 = new Firefox();
            windowWidth = firefox1.GetWindowWidth();
            Console.WriteLine("Window width (default constructor): " + windowWidth);

            // Create Firefox object using parameterized constructor with int
            Firefox firefox2 = new Firefox(1200);
            windowWidth = firefox2.GetWindowWidth();
            Console.WriteLine("Window width (parameterized constructor with int): " + windowWidth);

            // Create Firefox object using parameterized constructor with double
            Firefox firefox3 = new Firefox(1920);
            windowWidth = firefox3.GetWindowWidth();
            Console.WriteLine("Window width (parameterized constructor with double): " + windowWidth);


            // EXERCISE 2
            Console.WriteLine("\nExercise 2: Displaying XPaths from HomePage class");

            // Create HomePage object and call DisplayXPaths() method
            HomePage homePage = new HomePage();
            homePage.DisplayXPaths();


            // EXERCISE 3   

            // Call the TestRunner method for all Firefox objects
            Console.WriteLine("\nExercise 3: Running tests for Firefox objects");
            TestsRunner testsRunner = new TestsRunner();
            testsRunner.Run(firefox1);
            testsRunner.Run(firefox2);
            testsRunner.Run(firefox3);

            Console.ReadKey();

        }
    }
}
