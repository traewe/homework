using System;
namespace Program1
{
    class World
    {
        static void Main(string[] args)
        {
            double energystart = 0;
            double energyfinish = 0;
            double money = 0;
            Console.WriteLine("Enter value for energy at start: ");
            energystart = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value for energy at finish: ");
            energyfinish = Convert.ToDouble(Console.ReadLine());
            if (energyfinish - energystart <= 250)
            {
                money = (energyfinish - energystart) * 1.44;
            }
            else
            {
                money = 250 * 1.44 + (energyfinish - energystart - 250) * 1.68;
            }
            Console.WriteLine("Amount of money: " + money);
        }
    }
}