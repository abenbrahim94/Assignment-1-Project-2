using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            bool prompt;

            //Codes
            Console.WriteLine("\"Welcome to Program2\"");
            Console.WriteLine();
            Console.Write("Answer True or False ");
            Console.WriteLine();
            Console.WriteLine("Are you a male");
            prompt = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Your Response is: \"{0}\"", prompt);
            Console.WriteLine();
            Console.WriteLine("\"Press any key to exit\"");
            Console.ReadKey();
        }
    }
}
