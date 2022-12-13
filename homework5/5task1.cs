using System;
using System.Collections.Generic;

namespace Program
{
    class Homework
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10};
            Console.WriteLine(firstindex(array, 10));
            Console.WriteLine(lastindex(array, 10));
        }
        static int firstindex(int[] array, int digit)
        {
            int left = 0;
            int right = array.Length - 1;
            int first = -1;
            while (left <= right)
            {
                if (first != -1)
                {
                    right = first;
                }
                int i = (left + right) / 2;
                if (array[i] == digit)
                {
                    first = i;
                }
                else if (digit < array[i])
                {
                    right = i - 1;
                }
                else if (digit > array[i])
                {
                    left = i + 1;
                }
                if (right == left)
                {
                    if (array[right] == digit)
                    {
                        return right;
                    }
                }
            }
            return -1;
        }
        static int lastindex(int[] array, int digit)
        {
            int left = 0;
            int right = array.Length - 1;
            int last = -1;
            while (left <= right)
            {
                if (last != -1)
                {
                    left = last;
                }
                int i = (left + right) / 2;
                if (array[i] == digit)
                {
                    last = i;
                }
                else if (digit < array[i])
                {
                    right = i - 1;
                }
                else if (digit > array[i])
                {
                    left = i + 1;
                }
                if (right == left || left == right - 1)
                {
                    if (array[right] == digit)
                    {
                        return right;
                    }
                    else if (array[left] == digit)
                    {
                        return left;
                    }
                }
            }
            return -1;
        }
    }
}