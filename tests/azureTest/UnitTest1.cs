using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace azureTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, 2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, 3);
        }
    }
}
