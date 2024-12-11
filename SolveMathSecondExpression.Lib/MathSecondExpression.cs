namespace SolveMathSecondExpression.Lib
{
    public class MathSecondExpression
    {
        public double Zfunc2(double x2, double y2, double a2)
        {
            return (2 * a2 / y2) + (4 * x2) + ((2 - 3 * a2) / (x2 - 7 * y2)) + (((a2 - 3) / (x2 + 3)) / (3 * a2 / (x2 - 1)));
        }
    }
}
