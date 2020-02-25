/*
 * нахождения расстояния между двумя точками
 */using System;

namespace HomeWork
{
    class task3
    {
        static double distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main()
        {
            double x1, x2, y1, y2;

            Console.WriteLine("Введите первую точку, сначала x потом y");

            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите следующую точку");

            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"Расстояние между двумя точками : {distance(x1, y1, x2, y2):F2}");
            Pause();

        }

    }
}