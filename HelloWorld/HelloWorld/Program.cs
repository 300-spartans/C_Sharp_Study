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
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            double num1 = Double.Parse(string1);
            double num2 = Double.Parse(string2);

            Console.WriteLine(num1 + num2);
            Console.Read();

        }

        public static string GreetFriend(string name)
        {
            return "Hi " + name + ", my friend!";
        }
        
    }
}
