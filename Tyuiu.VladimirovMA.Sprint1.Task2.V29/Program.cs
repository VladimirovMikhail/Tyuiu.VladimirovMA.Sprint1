using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VladimirovMA.Sprint1.Task2.V29.Lib;

namespace Tyuiu.VladimirovMA.Sprint1.Task2.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 1 | Выполнил Владимиров М.А | АсоиУб23-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #1                                                                *");
            Console.WriteLine("*Тема: Арифметические операторы в С#                                      *");
            Console.WriteLine("*Задание: #2                                                              *");
            Console.WriteLine("*Вариант: #29                                                             *");
            Console.WriteLine("*Выполнил Владимиров Михаил Александрович | АсоиУб-23-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя количество        *");
            Console.WriteLine("*секунд и конвертирует его в минуты.                                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");
            
            int seconds;
            
            Console.WriteLine("Введите количество секунд:");
            seconds = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Время в минутах = " + ds.ConvertSecondsToHours(seconds));

            Console.ReadLine();

        }
    }
}
