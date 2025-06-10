using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_5
{
    public class AccessModifiersChildClass : AccessModifiers
    {
        public override void TestAccess()
        {
            TestPublic();
            TestInternal();
            TestProtected();
            TestInternalProtected();
            // TestPrivate();
            // TestDefaultPrivate();
        }
    }
}
