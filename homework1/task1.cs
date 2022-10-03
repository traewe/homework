using System;
namespace Program1
{
    class World
    {
        static void Main(string[] arg)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            Console.WriteLine("Enter Value for a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value for b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value for c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Value for d: ");
            d = Convert.ToInt32(Console.ReadLine());
            if (a < b)
            {
                if (a < c)
                {
                    if (a < d)
                    {
                        Console.WriteLine("A is minimim: " + a);
                    }
                    else
                    {
                        Console.WriteLine("D is minimum: " + d);
                    }
                }
                else
                {
                    if (c < d)
                    {
                        Console.WriteLine("C is minimim: " + c);
                    }
                    else
                    {
                        Console.WriteLine("D is minimum: " + d);
                    }
                }
            }
            else
            {
                if (b < c)
                {
                    if (b < d)
                    {
                        Console.WriteLine("B is minimim: " + b);
                    }
                    else
                    {
                        Console.WriteLine("D is minimum: " + d);
                    }
                }
                else
                {
                    if (c < d)
                    {
                        Console.WriteLine("C is minimim: " + c);
                    }
                    else
                    {
                        Console.WriteLine("D is minimum: " + d);
                    }
                }

            }
        }
    }
}