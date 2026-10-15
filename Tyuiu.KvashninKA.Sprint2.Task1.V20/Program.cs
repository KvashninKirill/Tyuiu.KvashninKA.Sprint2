using Tyuiu.KvashninKA.Sprint2.Task1.V20.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task1.V20;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
        Console.WriteLine("* Задание #1                                                                                           *");
        Console.WriteLine("* Вариант #20                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность                   *");
        Console.WriteLine("* можно чередовать, но использовать один раз в выражении) и логических операций (|, &, ||,             *");
        Console.WriteLine("* &&, !, ^, последовательность операций не должна нарушаться), а также арифметических                  *");
        Console.WriteLine("* выражений, которая вернет логическую последовательность(массив): (False, False, False, True,         *");
        Console.WriteLine("* True, True), при a = 242, b = 155, c = 456, d = 17                                                   *");
        Console.WriteLine("********************************************************************************************************");

        int a = 242;
        int b = 155;
        int c = 456;
        int d = 17;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadLine();
    }
}