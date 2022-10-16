using System;
namespace Program
{
    class World
    {
        static void Main(string[] args)
        { 
            int m = 0;
            int nfactorial = 1;
            int mfactorial = 1;
            int nmfactorial = 1;
            int counter = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int n = i; n >= counter; counter++)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        mfactorial *= j;
                    }
                    for (int j = 1; j <= n; j++)
                    {
                        nfactorial *= j;
                    }
                    for (int j = 1; j <= n - m; j++)
                    {
                        nmfactorial *= j;
                    }
                    Console.Write(nfactorial / (mfactorial * nmfactorial) + " ");
                    nfactorial = 1;
                    mfactorial = 1;
                    nmfactorial = 1;
                    m++;
                }
                counter = 0;
                m = 0;
                Console.WriteLine("");
            }
        }
    }
}