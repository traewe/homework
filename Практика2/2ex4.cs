using System;
class World
{
    static void Main(string[] args)
    {
        int a = 0;
        int Sum = 0;
        string s = "";
        Console.WriteLine("Enter a row of numbers: ");
        s = Convert.ToString(Console.ReadLine());
        string[] nums = s.Split(", ");
        for (int i = 0; i < nums.Length; i++)
        {
            Sum += Convert.ToInt32(nums[i]);
        }
        if (Sum % 2 == 0)
        {
            Console.WriteLine("Парне");
        }
        else
        {
            Console.WriteLine("Непарне");
        }
    }
}