/*
 * Зоммер Андрей вывод информации разными способами
 */using System;

namespace HomeWork
{
    class tasks1_2
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main()
        {
            string Name, LastName, Height, Weight;

            Console.Write("Введите свое имя : ");
            Name = Console.ReadLine();
            Console.Write("Введите свою фамилию : ");
            LastName = Console.ReadLine();
            Console.Write("Введите свой рост в сантиметрах : ");
            Height = Console.ReadLine();
            Console.Write("Введите свой вес : ");
            Weight = Console.ReadLine();

            double m = Convert.ToDouble(Weight);
            double h = Convert.ToDouble(Height);

            Console.WriteLine("Вас зовут : " + LastName + " "+ Name + ", Ваш рост и вес : " + Height + " " + Weight + " соотвественно");
            Console.WriteLine("Вас зовут : {0} {1}, Ваш рост и вес {2} {3} соотвественно", LastName, Name, Height, Weight);
            Console.WriteLine($"Вас зовут : {LastName} {Name}, Ваш рост и вес {Height} {Weight} сооствественно");

            Console.WriteLine($"Индекс массы : {(m*100*100)/(h*h):F2}");

            Pause();
        }
    }
}