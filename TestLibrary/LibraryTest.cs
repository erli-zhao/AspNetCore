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

        [TestMethod]
        public void ThingsGetName()
        {
            var result = new Thing()
            {
                LastName = "Li",
                 FirstName = "Ming"
            }.ToString();
            Assert.AreEqual("Li,Ming", result);
        }

        [TestMethod]
        public void RefTest()
        {

        }

    }
}
