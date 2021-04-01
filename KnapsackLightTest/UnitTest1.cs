using KnapsackLight;
using NUnit.Framework;

namespace KnapsackLightTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(10, Kata.KnapsackLight(10, 5, 6, 4, 8));

            Assert.AreEqual(16, Kata.KnapsackLight(10, 5, 6, 4, 9));

            Assert.AreEqual(0, Kata.KnapsackLight(10, 2, 11, 3, 1));

            Assert.AreEqual(15, Kata.KnapsackLight(15, 2, 20, 3, 2));

            Assert.AreEqual(3, Kata.KnapsackLight(2, 5, 3, 4, 5));

            Assert.AreEqual(4, Kata.KnapsackLight(4, 3, 3, 4, 4));

            Assert.AreEqual(3, Kata.KnapsackLight(3, 5, 3, 8, 10));
        }
    }
}