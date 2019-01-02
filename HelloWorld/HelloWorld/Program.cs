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
            Console.WriteLine("Please enter a number: ");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Please enter another number: ");
            string userInput2 = Console.ReadLine();

            try
            {
                int userInputAsInt1 = int.Parse(userInput1);
                int userInputAsInt2 = int.Parse(userInput2);
                int div = userInputAsInt1 / userInputAsInt2;

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNull exception");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter correct type");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception");
            }
            finally
            {
                Console.WriteLine("This is called regardless");
            }

            Console.Read();

        }

    }
}
