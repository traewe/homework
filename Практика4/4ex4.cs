using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            double sum = 0;
            List<double> sums = new(); 
            double[,] matrix = new double[8, 4];
            string length;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i, j] = (Math.Pow(i, 3) - 5 * Math.Pow(j, 2) - 1.8);
                    sum += matrix[i, j];
                }
                sums.Add(sum);
                sum = 0;
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    length = Convert.ToString(matrix[i, j]);
                    while (length.Length < 5)
                    {
                        Console.Write(" ");
                        length = length + "1";
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("Sum of " + (i + 1) +" row = " + Math.Round(sums[i], 4));
            }
        }
    }
}