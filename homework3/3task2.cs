using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            int size;
            int counterdots = 0;
            Console.WriteLine("Enter value for size: ");
            size = Convert.ToInt32(Console.ReadLine());
            int counterspace = size * 2 - 3;
            //Верхня межа
            Console.Write("#");
            for (int i = 0; i < size * 4; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("#");
            //Верхня частина
            for (int i = 0; i < size - 1; i++)
            {
                counterdots = 0;
                for (int k = counterspace; k > 0; k--)
                {
                    Console.Write(" ");
                }
                counterspace -= 2;
                Console.Write("| <>");
                for (int j = 0; j < i * 4; j++)
                {
                    Console.Write(".");
                    counterdots++;
                }
                Console.WriteLine("<> |");
            }
            //Центр
            for (int k = counterspace; k > 0; k--)
            {
                Console.Write(" ");
            }
            Console.Write("|<>");
            for (int i = 0; i < counterdots + 4; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("<>|");
            for (int k = counterspace; k > 0; k--)
            {
                Console.Write(" ");
            }
            Console.Write("|<>");
            for (int i = 0; i < counterdots + 4; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine("<>|");
            counterspace++;
            //Нижня частина
            for (int i = size - 1; i > 0; i--)
            {
                for (int k = counterspace + 1; k > 0; k--)
                {
                    Console.Write(" ");
                }
                counterspace += 2;
                Console.Write("| <>");
                for (int j = 0; j < (i - 1) * 4; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine("<> |");
            }
            //Нижня межа
            Console.Write("#");
            for (int i = 0; i < size * 4; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("#");
        }
    }
}