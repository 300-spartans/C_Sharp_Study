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

            Console.WriteLine("Current high score is {0}, held by {1}.", highScore, highscorePlayer);
            Console.WriteLine("What is your gamertag? ");
            string playerName = Console.ReadLine();
            Console.WriteLine("What is your highscore? ");
            string playerScoreInput = Console.ReadLine();
            if (int.TryParse(playerScoreInput, out int playerScore))
            {
                Compare(playerName, playerScore);
            }
            else
            {
                Console.WriteLine("Invalid score value.");
            }
            Console.Read();
        }

        public static void Compare(string playerName, int score)
        {
            if (score > highScore)
            {
                highScore = score;
                highscorePlayer = playerName;
                Console.WriteLine("New highscore is {0}, held by {1}.", highScore, highscorePlayer);

            }
            else
            {
                Console.WriteLine("The old score of {0} could not be broken and is still held by {1}.", highScore, highscorePlayer);
            }

        }
    }
}
