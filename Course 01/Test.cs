// using - includes namespaces in the program
using System;

// namespace - represents a collection of classes
namespace Course_1
{
    // class - user-defined blueprint / prototype from which objects are created
    class Test
    {
        // method - set of statements that perform a specific task
        static void Main(string[] args)
        {
            // statements - lines of code that perform a specific task
            Console.WriteLine("Hello, World!");

            // Create objects of the Browser class 
            Browser browser1 = new Browser();           // Using the default constructor
            Browser browser2 = new Browser(2048);       // Using the constructor with parameters
                                                        
            // Call the ChangeWindowWidth() method for each Browser object
            browser1.ChangeWindowWidth(1920);
            browser2.ChangeWindowWidth(1600);

            Console.ReadKey();

        }
    }
}
