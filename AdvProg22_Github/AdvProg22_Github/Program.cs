using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvProg22_Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.Write("Hello, what is your name: ");
            yourName = Console.ReadLine();

            Print();
            Console.WriteLine("Your name is " + yourName);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public static void Print()
        {
            Random rnd = new Random();

            for(int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 15);
                for(int j = 10; j > 0; j--)
                {
                    Console.BackgroundColor = (ConsoleColor)rnd.Next(1, 15);
                }
            }
        }

    }
}
