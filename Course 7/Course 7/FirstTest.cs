using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Course_7
{
    [TestFixture]
    public class FirstTest
    {
        [Test]
        public void FirstNunitTest()
        {
            Assert.That(true, Is.True, "This is the modern NUnit 4 way.");
        }
    }
}
