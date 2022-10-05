using System;
class World
{
    static void Main(string[] args)
    {
        double a = 0;
        double b = 0;
        double c = 0;
        Console.WriteLine("Enter Value for a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Value for b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Value for c: ");
        c = Convert.ToDouble(Console.ReadLine());
        double p = (a + b + c) / 2;
        double S = Math.Pow((p * (p - a) * (p - b) * (p - c)), 0.5);
        Console.WriteLine("Square = " + S);
    }
}