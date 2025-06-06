using Course_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutsideAssembly
{
    class AccessModifiersOutsideAssembly
    {
        public void TestAccess()
        {
            AccessModifiers am = new AccessModifiers();
            am.TestPublic();
            // am.TestInternal();
            // am.TestProtected();
            // am.TestInternalProtected();
            // am.TestPrivate();
            // am.TestDefaultPrivate();
        }
    }
}
