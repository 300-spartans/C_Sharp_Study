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
            string myName = "Sam";

            string message = "My name is " + myName;

            message.ToUpper();

            Console.WriteLine(message);
            Console.Read();

        }

        
    }
}
