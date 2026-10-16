
using Tyuiu.KvashninKA.Sprint2.Task7.V1.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task7.V1;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                            *");
        Console.WriteLine("* Тема: Алгоритмы разветвляющейся структуры в C#                                                       *");
        Console.WriteLine("* Задание #7                                                                                           *");
        Console.WriteLine("* Вариант #1                                                                                           *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные (вещественные                          *");
        Console.WriteLine("* значения) и вычисляет, находится ли точка с координатами X,Y в заштрихованной области.               *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        Console.WriteLine("Введите значение Х:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");
        
        if (res)
        {
            Console.WriteLine("Точка находится в закрашенной области");
        }
        else
        {
            Console.WriteLine("Точка не находится в закрашенной области");
        }


        Console.ReadLine();
    }
}