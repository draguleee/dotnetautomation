using NUnit.Framework;
using page_objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    [TestFixture]
    public class TestIndexPage : TestBase
    {
        // E2E Login Test
        [Test]
        public void LogIn()
        {
            GetIndexPage().ScrollToSection(1).FillTextInputs("Andre", "aandreid14@gmail.com", "12345678").Wait(1000)
                          .ScrollToSection(2).SelectRadioButton("female").Wait(1000)
                          .ScrollToSection(3).SelectCheckbox("coding").Wait(1000)
                          .ScrollToSection(4).FillTextArea("My name is Andre and this is Automation Practice demo.")
                          .ScrollToSection(5).SelectFromDropdown("ro").Wait(1000)
                          .ScrollToSection(6).SubmitForm().Wait(1000);
        }
    }
}
