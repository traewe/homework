using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            double product = 1;
            List<double> products = new();
            double[,] matrix = new double[7, 5];
            string length;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = (Math.Pow(2, i) + Math.Pow(j, 2) - 15);
                    product *= matrix[i, j];
                }
                products.Add(product);
                product = 1;
            }
            for (int i = 0; i < 7; i++)
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
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Product of " + (i + 1) + " row = " + Math.Round(products[i], 5));
            }
        }
    }
}