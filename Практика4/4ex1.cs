using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            double positivesum = 0;
            double negativeproduct = 1;
            double[,] matrix = new double[4, 6];
            string length = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = Math.Round((Math.Pow(i, 2) - 5) / (i + j + 3), 4);
                    if (matrix[i, j] > 0)
                    {
                        positivesum += matrix[i, j];
                    }
                    else if (matrix[i, j] < 0)
                    {
                        negativeproduct *= matrix[i, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
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
            Console.WriteLine("Sum of positive numbers = " + positivesum);
            Console.WriteLine("Product of negative numbers = " + negativeproduct);
        }
    }
}