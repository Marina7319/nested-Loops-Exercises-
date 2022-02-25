using System;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input = Console.ReadLine();
            int seats = 0;
            int sit = 1;
            int standard = 0;
            int student = 0;
            int kid = 0;
            int sum;
            double total =0;
            int sumKid =0;
            int sumStudent=0;
            int sumStandard=0;
            int movieNum=0; 
            while (input != "Finish")
            {
                seats = int.Parse(Console.ReadLine());              
                string ticketsType = "";
                for (int i = 1; i <= seats; i++)
                {                   
                     ticketsType = Console.ReadLine();
                    if (ticketsType == "standard")
                    {
                        standard += 1;
                    }
                    if (ticketsType == "student")
                    {
                        student += 1;
                    }
                    if (ticketsType == "kid")
                    {
                        kid += 1;
                    }
                    if (ticketsType == "End")
                    {
                        sum = kid + student + standard;
                        total += sum;
                        sumKid += kid;
                        sumStudent += student;
                        sumStandard += standard;
                        Console.WriteLine($"{input} - {(sum/seats):f2} full");
                        movieNum++;
                    }
                }

                input = Console.ReadLine();
            }
              Console.WriteLine($"Total tickets: {total}");
            //  double studentTickets = student * allTickets / 100;
            //  double standartTickets = standart * allTickets / 100;
           //   double kidsTickets = kid * allTickets / 100;
              Console.WriteLine($"{(sumStudent * total/100):f2}% student tickets.");
        }
    }
}
