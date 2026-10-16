
using Tyuiu.KvashninKA.Sprint2.Task4.V4.Lib;
namespace Tyuiu.KvashninKA.Sprint2.Task3.V18;

internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Квашнин К. А. | ПКТб-26-1";
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                                            *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                                     *");
        Console.WriteLine("* Задание #4                                                                                           *");
        Console.WriteLine("* Вариант #4                                                                                           *");
        Console.WriteLine("* Выполнил: Квашнин Кирилл Александрович | ПКТБ-26-1                                                   *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                             *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с использованием                            *");
        Console.WriteLine("* терннароного оператора, где пользователь вводит значение переменной X,Y с клавиатуры.                *");
        Console.WriteLine("* Если х + 2 < y, то z = sin(x) + 2y иначе cos(y) + 2xy                                                *");
        Console.WriteLine("* Округлить полученное значение до трех знаков после запятой;                                          *");
        Console.WriteLine("*                                                                                                      *");
        Console.WriteLine("********************************************************************************************************");



        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                     *");
        Console.WriteLine("********************************************************************************************************");

        Console.WriteLine("Введите значение переменной X:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y:");
        double y = Convert.ToDouble(Console.ReadLine());

        double res = ds.Calculate(x, y);

        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                           *");
        Console.WriteLine("********************************************************************************************************");
        Console.WriteLine($"Значение функции Z = {res:f3}");


        Console.ReadLine();
    }
}