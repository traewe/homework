using System;
class World
{
    static void Main(string[] args)
    {
        int a = 0;
        int Sum = 0;
        Console.WriteLine("Enter value for a: ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a < 0)
        {
            Console.WriteLine("a cannot be negative");
        }
        else
        {
            for (int i = 1; i < a; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Sum += i;
                }
            }
            Console.WriteLine(Sum);
        }
    }
}