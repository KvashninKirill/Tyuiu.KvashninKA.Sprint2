using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KvashninKA.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int n)
        {
            int dayInMonth = 0;
            switch (m)
            {
                case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                    dayInMonth = 31;
                    break;
                case 4: case 6: case 9: case 11:
                    dayInMonth = 30;
                    break;
                case 2:
                    dayInMonth = 28;
                    break;
                default:
                    throw new ArgumentException("Месяц должен быть от 1 до 12");

            }

            n++;
            if (n > dayInMonth)
            {
                n = 1;
                m++;
                if (m > 12)
                {
                    m = 1;
                }
            }

            return $"{n}.{m}";
        }
    }
}