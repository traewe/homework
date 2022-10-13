using System;
class World
{
    static void Main(string[] args)
    {
        int a = 0;
        int b = 0;
        int c = 0;
        int Sum = 0;
        string s = "";
        Console.WriteLine("Enter a row of numbers: ");
        s = Convert.ToString(Console.ReadLine());
        string[] nums = s.Split(", ");
        a = Convert.ToInt32(nums[0]);
        b = Convert.ToInt32(nums[1]);
        c = Convert.ToInt32(nums[2]);
        for (int i = a; i <= b; i += c)
        {
            Sum += i;
        }
        Console.WriteLine(Sum);
    }
}