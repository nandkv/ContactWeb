using ContactWeb.Models;
using NUnit.Framework;

namespace ContactWeb.Tests.Models
{
    [TestFixture]
    public class ContactTest
    {
        [Test]
        public void VerifyContactInit()
        {
            Contact c = new Contact();
            Assert.That(c, !Is.Null);
        }

        [Test]
        public void VerifyContactNotInited()
        {
            Contact c = null;
            Assert.That(c, Is.Null);
        }
    }
}
