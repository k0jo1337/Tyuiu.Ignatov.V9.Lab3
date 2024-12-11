namespace SolveMathFirstExpression.Lib
{
    public class MathFirstExpression
    {
        public double Zfunc1(double x, double y, double a)
        {
            return 12 * a - (3 * x + 2 * a + a) / (3 * a + 2 * x - y) + 12 * x + (((a - 1) / (y + 3)) / ((5 + a) / x));
        }
    }
}
