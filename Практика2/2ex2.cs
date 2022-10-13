using System;
class World
{
    static void Main(string[] args)
    {
        int a = 0;
        int temp = 0;
        int counter = 0;
        Console.WriteLine("Enter Value for a: ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a < 0)
        {
            Console.WriteLine("Digit cannot be negative");
        }
        else
        {
            List<int> nums = new List<int>();
            while (a != 0)
            {
                temp = a % 10;
                nums.Add(temp);
                a = a / 10;
                counter++;
            }
            for (int i = 0; i < counter - 1; i++)
            {
                for (int j = i + 1; j < counter; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write(nums[i]);
            }
        }
    }
}