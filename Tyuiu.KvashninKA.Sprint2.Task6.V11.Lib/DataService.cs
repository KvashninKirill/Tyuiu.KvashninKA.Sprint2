using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KvashninKA.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                4 or 6 or 9 or 11 or 11 => 30,
                2 => 28,
                _ => throw new ArgumentException("Некоректный номер месяца")
            };

            n++;
            if (n > daysInMonth)
            {
                n = 1;
                m++;
                if (m > 12)
                {
                    m = 1;
                    g++;
                }
            }

            return $"{n:D2}.{m:D2}.{g}";
        }
    }
}