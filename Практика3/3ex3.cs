using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            decimal money = Convert.ToDecimal(Console.ReadLine());
            int counter = 0;
            while (money >= Convert.ToDecimal(0.25))
            {
                money -= Convert.ToDecimal(0.25);
                counter++;
            }
            while (money >= Convert.ToDecimal(0.1))
            {
                money -= Convert.ToDecimal(0.1);
                counter++;
            }
            while (money >= Convert.ToDecimal(0.05))
            {
                money -= Convert.ToDecimal(0.05);
                counter++;
            }
            while (money >= Convert.ToDecimal(0.01))
            {
                money -= Convert.ToDecimal(0.01);
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}