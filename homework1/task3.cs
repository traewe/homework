using System;
namespace Program1
{
    class World
    {
        static void Main(string[] args)
        {
            double x1 = 0;
            double y1 = 0;
            double x2 = 0;
            double y2 = 0;
            Console.WriteLine("Enter Value for x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Value for y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Value for x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Value for y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            double x = Math.Pow((x1 - x2), 2);
            double y = Math.Pow((y1 - y2), 2);
            double length = Math.Pow((x + y), 0.5);
            Console.WriteLine("Length = " + length);
        }
    }
}