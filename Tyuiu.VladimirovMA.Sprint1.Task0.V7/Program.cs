using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VladimirovMA.Sprint1.Task0.V7.Lib;

namespace Tyuiu.VladimirovMA.Sprint1.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #1                                                                *");
            Console.WriteLine("*Тема: Базовые навыки работы в С#                                         *");
            Console.WriteLine("*Задание: #0                                                              *");
            Console.WriteLine("*Вариант: #7                                                              *");
            Console.WriteLine("*Выполнил Владимиров Михаил Александрович | АсоиУб-23-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу, которая вычисляет 18/6*2-(4-3)                       *");
            Console.WriteLine("*и печатает результат на экране                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*18 / 6 * 2 - (4 - 3)                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
