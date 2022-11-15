using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double[,] matrix = new double[10, 5];
            string length;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = Math.Pow(j, 2) - 8 * i + 35;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    length = Convert.ToString(matrix[i, j]);
                    while (length.Length < 3)
                    {
                        Console.Write(" ");
                        length = length + "1";
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += matrix[i, j];
                }
                Console.WriteLine("Sum of " + (j + 1) + " column = " + sum);
                sum = 0;
            }
        }
    }
}