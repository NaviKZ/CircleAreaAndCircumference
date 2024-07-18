using System;

namespace CircleAreaAndCircumference
{
    internal class CircleAreaAndCircumference
    {
        static void Main(string[] args)
        {
            int radius = 30; //TODO: Осуществить ввод с консоли
            double circleArea = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine("Площадь круга равна: {0,20:f4}", circleArea);
            Console.WriteLine("Длина окружности равна: {0,16:f4}", circumference);

            Console.ReadKey();
        }
    }
}
