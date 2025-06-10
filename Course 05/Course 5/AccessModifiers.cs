using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_5
{
    public class AccessModifiers
    {
        // Method to test all the access modifiers
        public virtual void TestAccess()
        {
            TestPublic();
            TestInternal();
            TestProtected();
            TestInternalProtected();
            TestPrivate();
            TestDefaultPrivate();
        }

        // Public method - access everywhere

        public void TestPublic() { }

        // Internal method - access in the containing classes and containing assembly
        internal void TestInternal() { }

        // Protected method - access in the containing and derived classes
        protected void TestProtected() { }

        // Internal Protected method - access to containing and derived classes and containing assembly
        internal protected void TestInternalProtected() { }
        
        // Private method - access only in the containing classes
        private void TestPrivate() { }

        // Default method - private
        void TestDefaultPrivate() { }
    }
}
