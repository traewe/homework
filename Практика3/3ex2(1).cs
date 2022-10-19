using System;
namespace Program;
    class World
{
    static void Main(string[] args)
    {
        int H = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < H; i++)
        {
            for (int j = 1; j < H - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        }
    }
}