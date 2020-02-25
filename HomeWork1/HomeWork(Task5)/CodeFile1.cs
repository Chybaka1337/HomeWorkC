/*
 * Вывод в центр окна консоли
 */using System;

namespace HomeWork
{
    class task5
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main()
        {
            Console.SetWindowSize(70, 30);
            Console.SetBufferSize(70, 30);
            Console.SetCursorPosition(25, 13);

            Console.WriteLine("Зоммер Андрей, город Тула");

            Pause();
        }
    }
}