using BusinessLogic;
using NUnit.Framework;

namespace BusinessLogicTest
{
    public class MyMathTest
    {
        [Test]
        [TestCase(9, 18, 27)]
        [TestCase(10, 30, 40)]
        [TestCase(4, 4, 5)]
        public void TestGcd(int result, int a, int b)
        {
            var myMath = new MyMath();
            Assert.AreEqual(result, myMath.Gcd(a, b));
        }
    }
}