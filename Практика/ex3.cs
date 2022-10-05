using System;
namespace Program1
{
    class World
    {
        static void Main(string[] args)
        {
            double month = 0;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Enter number of month: ");
            month = Convert.ToDouble(Console.ReadLine());
            if (month < 3 || month == 12)
            {
                Console.WriteLine("Зима");
            }
            else if (2 < month && month < 6)
            {
                Console.WriteLine("Весна");
            }
            else if (5 < month && month < 9)
            {
                Console.WriteLine("Літо");
            }
            else
            {
                Console.WriteLine("Осінь");
            }
        }
    }
}