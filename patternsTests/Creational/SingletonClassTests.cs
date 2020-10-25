using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidPatternsCore.Patterns;

namespace SolidPatternsCore.PatternsTests
{
    [TestClass]
    public class SingletonClassTests
    {
        [TestMethod]
        public void ShouldReturnSameInstanceWithMultipleCalls()
        {
            SingletonClass first = SingletonClass.Instance;
            SingletonClass second = SingletonClass.Instance;
            Assert.AreSame(first, second);
            first.SomeValue++;
            Assert.AreEqual(first.SomeValue, second.SomeValue);
            second.SomeValue++;
            Assert.AreEqual(first.SomeValue, second.SomeValue);
            first.Dispose();
            second.Dispose();
        }
    }
}