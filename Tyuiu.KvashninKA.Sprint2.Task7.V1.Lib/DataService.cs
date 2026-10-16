using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KvashninKA.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool inCircle = (x * x + y * y <= 1);
            bool aboveXAxis = (y >= 0);
            bool belowLine1 = (y >= x);
            bool belowLine2 = (y >= -x);

            return inCircle && aboveXAxis && belowLine1 && belowLine2;
        }
    }
}