using System;
namespace Program1
{
    class World
    {
        static void Main(string[] args)
        {
            double temp = 0;
            Console.WriteLine("Enter value for temperature: ");
            temp = Convert.ToDouble(Console.ReadLine());
            if (temp < 0)
            {
                Console.WriteLine("Агрегатний стан: твердий");
            }
            else if (-1 < temp && temp < 101)
            {
                Console.WriteLine("Агрегатний стан: рiдкий");
            }
            else
            {
                Console.WriteLine("Агрегатний стан: газоподiбний");
            }
        }
    }
}