using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            //броя на хората в журито N на брой оценяващи 
            int comisia = int.Parse(Console.ReadLine());
            // името на презентацията текст 
            string input = Console.ReadLine();
            double mark;
            int presentationNum = 0;
            double evaluation = 0;
            //N - на брой оценки 
            while (input != "Finish")
            {
                mark = 0;
                for (int i = 1; i <= comisia; i++)
                {
                    mark += double.Parse(Console.ReadLine());

                }
                mark = mark / comisia;
                evaluation += mark;
                Console.WriteLine($"{input} - {mark:f2}.");
                presentationNum++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {evaluation / presentationNum:f2}.");
        }
    }
}
