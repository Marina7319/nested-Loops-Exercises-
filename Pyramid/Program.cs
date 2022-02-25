using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 1;
            bool isBigger = false;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (currentNum > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(currentNum + " ");
                    currentNum++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}