using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course5.Exercise1
{
    public class Browser_1
    {
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
