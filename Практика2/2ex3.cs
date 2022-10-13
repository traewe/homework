using System;
class World
{
    static void Main(string[] args)
    {
        string s = "";
        Console.WriteLine("Enter a row of numbers");
        s = Convert.ToString(Console.ReadLine());
        string[] nums = s.Split(", ");
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[0])
            {
                if (nums[i] != nums[1] || nums[i] != nums[2])
                {
                    Console.WriteLine(nums[i]);
                    break;
                }
                else
                {
                    Console.WriteLine(nums[0]);
                    break;
                }
            }
        }
    }
}