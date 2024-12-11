using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolveMathSecondExpression.Lib;

namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public sealed class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestMethod1()
        {
            var z2 = new MathSecondExpression();
            int x2 = 2;
            int y2 = 4;
            int a2 = 7;
            double zf2 = z2.Zfunc2(x2, y2, a2);
            Assert.AreEqual(12.269, zf2, 0.001);
        }
    }
}
