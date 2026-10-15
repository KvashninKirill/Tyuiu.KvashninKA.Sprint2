using Tyuiu.KvashninKA.Sprint2.Task2.V22.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task2.V22;

internal class Program
{
    static void Main(string[] args)
    {
        

        Console.Title = "Спринт #2 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
        Console.WriteLine("* Задание #2                                                                                           *");
        Console.WriteLine("* Вариант #22                                                                                          *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и вычисляет находится         *");
        Console.WriteLine("* ли точка с координатами X,Y в заштрихованной области                                                 *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("********************************************************************************************************");

        

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        Console.WriteLine("Введите значение переменной X:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y:");
        int y = Convert.ToInt32(Console.ReadLine());

        DataService ds = new DataService();
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