using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_4
{
    public abstract class Browser
    {
        // Class variables
        private int windowWidth;

        /** ACCESORS & MUTATORS
        
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

        // Encapsulation using properties
        public int WindowWidth
        {
            get { return windowWidth; }
            set { windowWidth = value; }
        }

        // Method to change window width
        public abstract void ChangeWindowWidth(int windowWidth);

    }
}
