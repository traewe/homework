using System;
class World
{
    static void Main(string[] args)
    {
        string password = "";
        int digit = 0;
        Console.WriteLine("Enter value for password: ");
        password = Convert.ToString(Console.ReadLine());
        if (password.Length == 4 || password.Length == 6)
        {
            try
            {
                digit = Convert.ToInt32(password);
                Console.WriteLine("true");
            }
            catch
            {
                Console.WriteLine("false");
            }
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}