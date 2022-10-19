using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            long card = Convert.ToInt64(Console.ReadLine());
            long sum1 = 0;
            long sum2 = 0;
            string company = Convert.ToString(card);
            int number = 0;
            while (card > 0)
            {
                sum1 += card % 10;
                card /= 10;
                if (card != 0)
                {
                    if (2 * (card % 10) > 10)
                    {
                        sum2 += (2 * (card % 10)) % 10 + (2 * (card % 10)) / 10;
                    }
                    else
                    {
                        sum2 += 2 * (card % 10);
                    }
                    card /= 10;
                }
            }
            if (company[0..1] == "4")
            {
                company = "VISA";
            }
            number = Convert.ToInt32(company[0..2]);
            if (50 < number && number < 55) 
            {
                company = "MASTERCARD";
            }
            if ((sum1 + sum2) % 10 == 0)
            {
                if (sum2 == 16 && company == "MASTERCARD")
                {
                        Console.WriteLine(company);
                }
                if ((sum2 == 13 || sum2 == 16) && company == "VISA")
                {
                        Console.WriteLine(company);
                }
            }
            if ((sum1 + sum2) % 10 != 0 || (company != "VISA" && company != "MASTERCARD"))
            {
                Console.WriteLine("INVALID");
            }
        }
    }
}