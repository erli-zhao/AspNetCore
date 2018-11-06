using Golden;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibrary
{
    [TestClass]
    public class LibraryTest
    {
        [TestMethod]
        public void ThingsGetsObjectValFromNumber()
        {
            Assert.AreEqual(43, new Thing().Get(43));
        }
    }
}
