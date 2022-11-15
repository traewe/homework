using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            int zerocounter = 0;
            double[,] matrix = new double[5, 6];
            string length;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = Math.Round((i - j) / (2.5 * Math.Pow(i, 2) + j + 1), 4);
                    if (i == j)
                    {
                        zerocounter++;
                        matrix[i, j] = 10;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    length = Convert.ToString(matrix[i, j]);
                    while (length.Length < 7)
                    {
                        Console.Write(" ");
                        length = length + "1";
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Quantity of zeros = " + zerocounter);;
        }
    }
}