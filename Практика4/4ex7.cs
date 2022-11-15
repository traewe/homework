using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            double product = 1;
            double[,] matrix = new double[9, 6];
            string length;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = 9 * Math.Pow(i, 2) + Math.Pow(j, 2) - 50;
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 6; j++)
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
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    product *= matrix[i, j];
                }
                Console.WriteLine("Product of " + (j + 1) + " column = " + product);
                product = 1;
            }
        }
    }
}