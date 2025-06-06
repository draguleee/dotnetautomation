using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course5.Exercise2
{
    public class Browser
    {
        // Class variables
        public int ResolutionPublic;
        internal int ResolutionInternal;
        private int ResolutionPrivate;
        protected int ResolutionProtected;
        protected internal int ResultionProtectedInternal;
        int ResolutionDefault;

        // Method that throws an exception if the element was not found
        public void FindElement()
        {
            throw new Exception("Element not found.");
        }

        // Method to capture screen / set value for PathImage
        public void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch (Exception ex)
            {
                BrowserHelper.CaptureScreen();
            }
            finally
            {
                BrowserHelper.PathImage = "browser/test";
            }
        }
    }
}
