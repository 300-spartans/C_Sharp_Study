using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {

        static void Main(string[] args)
        {
            int average = GetAverage();
            Console.WriteLine("The average is {0}", average);
            Console.Read();
        }

        public static int GetAverage()
        {
            int totalScores = 0;
            int numberOfScores = 0;
            int numInput = 0;

            while (numInput != -1)
            {
                Console.WriteLine("Please enter score (between 0 and 20)" +
                "\nEnter -1 to get average");
                Console.WriteLine("Current number of entries: {0}", numberOfScores);

                string input = Console.ReadLine();
                Console.WriteLine("------------------------------------");

                if (!int.TryParse(input, out numInput)) 
                {
                    Console.WriteLine("Enter valid number score");
                    continue;

                } else if (numInput > 20)
                {
                    Console.WriteLine("Enter valid score");
                    continue;
                } else if (numInput == -1)
                {
                    break;
                }

                totalScores += numInput;
                numberOfScores++;
            }
            int average = totalScores / numberOfScores;
            return average;
        }
    }
}
