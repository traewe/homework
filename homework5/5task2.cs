using System;
namespace Program
{
    class Homework
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 3, 5, 7, 7, 7, 6, 4, 2, -1};
            Console.WriteLine(Binarysearch(array, -1));
        }
        static int Binarysearch(int[] array, int digit)
        {
            int top = Array.LastIndexOf(array, array.Max());
            int left = 0;
            int right = top;
            while (left <= right)
            {
                int i = (left + right) / 2;
                if (array[i] == digit)
                {
                    return i;
                }
                else if (array[i] < digit)
                {
                    left = i + 1;
                }
                else if (array[i] > digit)
                {
                    right = i - 1;
                }
            }
            left = top + 1;
            right = array.Length - 1;
            while (left <= right)
            {
                int i = (left + right) / 2;
                if (array[i] == digit)
                {
                    return i;
                }
                else if (array[i] < digit)
                {
                    right = i - 1;
                }
                else if (array[i] > digit)
                {
                    left = i + 1;
                }
            }
            return -1;
        }
    }
}