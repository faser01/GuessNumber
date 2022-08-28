using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Легко (0 - 50)");
            Console.WriteLine("2. Средне (0 - 100)");
            Console.WriteLine("3. Сложно (0 - 200)");

            Console.WriteLine("Выбор режима (напишите число): ");
            int regim = 0;

            Random ram = new Random();
            int num = 0;
            while (true)
            {
                regim = Convert.ToInt32(Console.ReadLine());
                if (regim == 1)
                {
                    num = ram.Next(0, 50);
                    break;
                }
                else if (regim == 2)
                {
                    num = ram.Next(0, 100);
                    break;
                }
                else if (regim == 3)
                {
                    num = ram.Next(0, 200);
                    break;
                }
                else
                    Console.WriteLine("Введено недопустимое число. Введите 1, 2, либо 3.");
            }

            Console.WriteLine("Я загадал число. Угадай его.");

            int input = 0;
            while (true)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (num > input)
                    Console.WriteLine("Моё число больше. :P");
                else if (num < input)
                    Console.WriteLine("Моё число меньше. :P");
                else
                {
                    Console.WriteLine("Поздравляем, Вы угадали! :) ");
                    break;
                }

            }
        }
    }
}

