using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        // constants as fields
        const double PI = 3.1415926539;
        const int weeks = 52, months = 12;
        const string birthday = "September 29, 1997";
        
        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}", birthday);
            Console.Read();
        }

        
    }
}
