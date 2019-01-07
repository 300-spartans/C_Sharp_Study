using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static int highScore = 8900;
        static string highscorePlayer = "300spartans";

        static void Main(string[] args)
        {
            int lengthOfText = 0;

            for (int counter = 1; counter <= 20; counter+=2)
            {
                Console.WriteLine(counter);
                Console.WriteLine("Counter incremented");
            }

            do
            {
                Console.WriteLine("Please enter the name of a friend:");
                string name = Console.ReadLine();
                int currentLength = name.Length;
                lengthOfText += currentLength;
            } while (lengthOfText < 20);

            Console.Read();
            
        }

        
    }
}
