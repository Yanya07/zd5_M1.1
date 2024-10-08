using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)// Цикл для вывода чисел от 1 до 100
            {
                if (i % 3 == 0 && i % 5 == 0)// Если число делится на 3 и на 5
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)// Если число делится только на 3
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)// Если число делится только на 5
                {
                    Console.WriteLine("Buzz");
                }
                else// В остальных случаях выводим само число
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");
            Console.ReadLine();
        }
    }
}
