/*
 * Обмен значениями без третьей переменной
 */using System;

namespace HomeWork
{
    class task4
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main()
        {
            double a, b;

            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());

            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine($"a = {a}, b = {b}");

            Pause();

        }
    }
}