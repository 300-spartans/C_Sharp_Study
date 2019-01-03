using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
                
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Login System \nEnter new username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter new password: ");
            string password = Console.ReadLine();

            Login(username, password);
            Console.Read();

        }

        public static void Login(string username, string password)
        {
            Console.WriteLine("Welcome {0}!", username);
            Console.WriteLine("Please enter password: ");
            string userInput = Console.ReadLine();

            if(userInput.Equals(password))
            {
                Console.WriteLine("You are logged in.");
            }
            else
            {
                Console.WriteLine("Incorrect password. Closing program.");
            }
        }
    }
}
