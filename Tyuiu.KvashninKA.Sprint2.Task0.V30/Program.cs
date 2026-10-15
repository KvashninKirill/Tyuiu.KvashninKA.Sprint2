using Tyuiu.KvashninKA.Sprint2.Task0.V30.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task0.V30;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
        Console.WriteLine("* Задание #0                                                                                           *");
        Console.WriteLine("* Вариант #30                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность                   *");
        Console.WriteLine("* операций не должна нарушаться) и арифметических выражений, которая вернет логическую                 *");
        Console.WriteLine("* последовательность(массив): (True, False, True, False, True, False), при x = 95, y = 1735            *");
        Console.WriteLine("********************************************************************************************************");

        int x = 95;
        int y = 1735;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);


        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");

        for (int i = 0; i<6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadLine();
    }
}