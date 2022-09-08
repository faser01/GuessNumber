using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessNumber
{
    class Ugaday4islo

    {
        // функция создания случайного числа в диапозоне от 1 до как получит через параметр
        static int GetRandom(int rNum)
        {
            // создание генератора случайных чисел
            Random rnd = new Random();
            // создание случайного числа 
            int value = rnd.Next(1, rNum);
            // возврат из функции созданого числа
            return value;
        }
        
        public static void Main(string[] args)
        {
            int iNum = 0; // инициализация числа 
            int pNum = 100; // инициализация числа для диапазона случайных чисел
            int rNum = GetRandom(pNum); // инициализация случайного числа из диапазона
            //окрас консоли .приветсвие и запрос имени
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.Write("Здравствуйте, это игра под названием <Угадай число>! \nКак вас зовут? ");
            string name = Console.ReadLine();
            for (int i = 1; i < 11; i++) // цикл от от 1 до 11. Это 10 попыток
            {
                // приветсвенное сообщение угадать число
                Console.Write(name + $" Угадай число от 1 до {pNum}! У тебя есть 10 попыток - Попытка {i}: \n");
                string sNum = Console.ReadLine(); // чтение введенного числа с клавиатуры
                // условие проверки ввода. число или буква
                if (int.TryParse(sNum, out iNum) && iNum <= pNum)
                {
                    if (iNum == rNum) // условие определения правильности числа
                    {
                        // вывод сообщения о правильности числа и прекращение цикла
                        Console.WriteLine("Вы угадали! Поздравляю!! Правильное число " + rNum);
                        break;
                    }
                    // услови если число меньше загаданного
                    if (iNum < rNum)
                    {
                        Console.WriteLine("Ваше число " + iNum + " а должно быть больше");
                    }
                    // условие если число больше загаданного
                    if (iNum > rNum)
                        Console.WriteLine("Ваше число " + iNum + "а должно быть меньше");

                }
                else
                {
                    // если введено не число или оно не соответствует диапазону pNum
                    Console.WriteLine("Нужно вводить число от 1 до " + pNum);
                }

            }
            // сообщение от том что число не угадано
            if (iNum != rNum)
                Console.WriteLine("Вы не угадали число!");
            // ожидания ввода с клавиатуры
            Console.ReadKey();
        }


    }
}

