using System;

namespace HW_Course6.Exercise1
{
    public class Firefox
    {
        // Class variable
        private int windowWidth;

        // Default constructor
        public Firefox()
        {
            windowWidth = 1000;
        }

        // Parameterized constructor (int parameter)
        public Firefox(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Window width cannot be negative.");
            }
            windowWidth = value;
        }

        // Parameterized constructor (double parameter)
        public Firefox(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Window width cannot be negative.");
            }
            windowWidth = (int)value; 
        }

        // Method to get the window width
        public int GetWindowWidth()
        {
            return windowWidth;
        }
    }
}
