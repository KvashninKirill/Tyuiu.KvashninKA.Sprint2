using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KvashninKA.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;
            if ((x >= 2 && x <= 5 && y >= 3 && y <= 10) ||
                (x >= 3 && x <= 4 && y >= 11 && y <= 11) ||
                (x >= 3 && x <= 5 && y >= 12 && y <= 12) ||
                (x >= 6 && x <= 9 && y >= 5 && y <= 7) ||
                (x >= 7 && x <= 8 && y >= 8 && y <= 11) ||
                (x >= 6 && x <= 6 && y >= 11 && y <= 11) ||
                (x >= 10 && x <= 12 && y >= 3 && y <= 9) ||
                (x >= 12 && x <= 12 && y >= 10 && y <= 11) ||
                (x >= 3 && x <= 10 && y >= 13 && y <= 14) ||
                (x >= 13 && x <= 13 && y >= 6 && y <= 18))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }

}