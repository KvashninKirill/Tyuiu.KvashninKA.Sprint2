
using Tyuiu.KvashninKA.Sprint2.Task6.V11.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task6.V11;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры в C#                                                       *");
        Console.WriteLine("* Задание #6                                                                                           *");
        Console.WriteLine("* Вариант #11                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое значение и                *");
        Console.WriteLine("* возвращает результат.                                                                                *");
        Console.WriteLine("* Условие: Дата некоторого дня характеризуется тремя натуральными числами: g (год), m                  *");
        Console.WriteLine("* (порядковый номер месяца) и n (число). По заданным g, n и m определить дату следующего               *");
        Console.WriteLine("* дня. Заданный год не является високосным.                                                            *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        Console.WriteLine("Введите номер месяца (m):");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число (n):");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите число (g):");
        int g = Convert.ToInt32(Console.ReadLine());

        string res = ds.FindDateOfNextDay(g, m, n);

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine($"Дата следующего дня: {res}");


        Console.ReadLine();
    }
}