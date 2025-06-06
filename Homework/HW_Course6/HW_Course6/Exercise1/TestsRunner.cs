using HW_Course6.Exercise1;
using System;

namespace HW_Course6.Exercise3
{
    public class TestsRunner
    {
        // Method to run the tests for Firefox class
        public void Run(Firefox firefox)
        {
            Console.WriteLine("Running Firefox browser with window width: " + firefox.GetWindowWidth());
        }
    }
}
