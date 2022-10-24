using System;
namespace Program
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            double l = 0, r = 0, e = 1, cub_a = 1, cal_a = 0;
            string symbol = "";
            Console.WriteLine("How many numbers after comma do you want?");
            int num_digits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < num_digits; i++)
            {
                e /= 10;
            }
            if (a < 0)
            {
                symbol = "-";
                a = -a;
            }
            if (a >= 1)
            {
                l = 1;
                r = a;
            }
            if (0 < a && a < 1)
            {
                l = 0;
                r = 1;
            }
            do
            {
                cub_a = (l + r) / 2;
                cal_a = cub_a * cub_a * cub_a;
                if (cal_a > a)
                {
                    r = cub_a;
                }
                else
                {
                    l = cub_a;
                }
            } while (Math.Abs(a - cal_a) > e);
                Console.WriteLine(String.Format(symbol + "{0:F" + num_digits + "}", cub_a));
        }
    }
}