using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        {
            Console.WriteLine(substr_lastindex("abcd", "cd"));

        }
        static int substr_lastindex(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            bool f;
            for (int i = 0; i < len1 - len2 + 1; i++)
            {
                f = true;
                for (int j = 0; j < len2; j++)
                {
                    if (str1[i + j] != str2[j])
                    {
                        f = false;
                        break;
                    }
                }
                if (f)
                {
                    return i + len2 - 1;
                }
            }
            return -1;
        }
    }
}