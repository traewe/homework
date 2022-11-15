using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            int poscounter = 0;
            int negcounter = 0;
            double[,] matrix = new double[4, 8];
            string length = "";
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = Math.Round((3 * Math.Pow(j, 2) - 35) / (i + 1.2 * j + 2), 6);
                    if (matrix[i, j] > 0)
                    {
                        poscounter++; ;
                    }
                    else if (matrix[i, j] < 0)
                    {
                        negcounter++;
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    length = Convert.ToString(matrix[i, j]);
                    while (length.Length < 10)
                    {
                        Console.Write(" ");
                        length = length + "1";
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Quantity of positive numbers = " + poscounter);
            Console.WriteLine("Quantity of negative numbers = " + negcounter);
        }
    }
}