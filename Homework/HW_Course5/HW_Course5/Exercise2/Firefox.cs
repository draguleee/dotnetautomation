using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Course5.Exercise2
{
    public class Firefox
    {
        public void TestAccess()
        {
            Browser browser = new Browser();
            Console.WriteLine("public: " + browser.ResolutionPublic);
            Console.WriteLine("internal: " + browser.ResolutionInternal);
            // Console.WriteLine("private: " + browser.ResolutionPrivate);
            // Console.WriteLine("protected: " + browser.ResolutionProtected);
            // Console.WriteLine("protected internal: " + browser.ResolutionProtectedInternal);
            // Console.WriteLine("default: " + browser.ResolutionDefault);
        }
    }
}
