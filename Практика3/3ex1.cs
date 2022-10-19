using System;
namespace Program;
class World
{
    static void Main(string[] args)
    {
        for (int i = 1; i < 11; i++)
        {
            for (int j = 1; j < 11; j++)
            {
                if (i * j < 10 || (j == 10) && (i < 10))
                {
                    Console.Write(" ");
                }
                Console.Write(i * j + " ");
            }
            Console.WriteLine("");
        }
    }
}