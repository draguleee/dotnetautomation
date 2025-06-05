using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course4
{
    public abstract class Browser
    {
        // Class variable
        private int windowWidth;

        /**
        
        // Accessors & Mutators (Getters & Setters)

        // Accesor (Getter) for windowWidth
        public int GetWindowWidth() 
        {
            return windowWidth;
        }

        // Mutator (Setter) for windowWidth
        public void SetWindowWidth(int windowWidth) 
        {
            this.windowWidth = windowWidth;
        }

        */

        // Encapsulation with properties
        public int WindowWidth
        {
            get { return windowWidth; }
            set 
            { 
                if (value >= 1024 && value <= 1920)
                {
                    windowWidth = value;
                }
                else
                {
                    Console.WriteLine("Window width must be in range [1024, 1920]!");
                }
            }
        }

        // Method to start the browser - to be implemented
        public abstract void StartBrowser();
    }
}
