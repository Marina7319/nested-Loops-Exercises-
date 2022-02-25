using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 0;
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;
            while (input != "stop")
            {
                numbers = int.Parse(input);
                if (numbers < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                bool prime = true;
                for (int i = 2; i <= numbers-1; i++)
                {
                    if (numbers % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
         

                if (prime)
                {
                    primeSum += numbers;
                }
                else
                {
                    nonPrimeSum += numbers;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
