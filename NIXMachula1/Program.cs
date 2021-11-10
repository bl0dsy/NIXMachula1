using System;

namespace NIXMachula1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Задание 1. Найдите площадь и периметр прямоугольника?");
            double sideA, sideB, area, perimeter;
            Console.WriteLine("Введите первое значение");
            sideA = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение");
            sideB = double.Parse(Console.ReadLine());
            area = sideA * sideB;
            perimeter = (sideA + sideB) * 2;
            Console.WriteLine($"Площадь = { area }");
            Console.WriteLine($"Периметр = {perimeter}");

        }
    }
}
