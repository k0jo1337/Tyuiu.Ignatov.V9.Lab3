using SolveMathFirstExpression.Lib;

namespace SolveMathFirstExpression.Test
{
    [TestClass]
    public sealed class ValidMathFirstExpression
    {
        [TestMethod]
        public void TestCalculateFirstExpression()
        {
            var z1 = new MathFirstExpression();
            int x = 2;
            int y = -2;
            int a = 5;
            double zf1 = z1.Zfunc1(x, y, a);
            Assert.AreEqual(83.8, zf1);
        }
    }
}
