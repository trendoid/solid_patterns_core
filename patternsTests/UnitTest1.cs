using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolidPatternsCore.PatternsTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = "expected";
            var actual = "expected";
            Assert.AreEqual(expected, actual);
        }
    }
}
