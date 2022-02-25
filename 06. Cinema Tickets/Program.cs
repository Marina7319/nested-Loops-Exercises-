using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            // не генерира всички числа в диапазона,
            // а генерира всички числа, които могат да се съставят от 1 и 9 по-скоро всички четирицифрени.
            for (int k = 1; k <= 9; k++)
            {
                for (int l = 1; ; l <= 9; l++)
                {
                for (int j = 1; j <= 9; j++)
                {

                    for (int i = 1; i <= 9; i++)
                    {
                        //правим проверка дали генерираното число е специално
                        if (n % i == 0 && n % j == 0 && n % o == 0 && n % k == 0)
                        {
                            Console.Write($"{k}{l}{j}{i} ");
                        }
                    }
                }
            }
        }
    }
}

