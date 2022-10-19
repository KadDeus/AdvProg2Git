using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AdvProg22_Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            PrintLine("test");
            Print("Rest");

            Console.WriteLine("Hello World");

            string yourName;
            Console.Write("Hello, what is your name: ");
            yourName = Console.ReadLine();


            PrintY();
            Console.WriteLine("Your name is " + yourName);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        static void PrintLine(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Random r = new Random();
                Console.ForegroundColor = (ConsoleColor)r.Next(1,14);
                Console.Write(text.Substring(i, 1));
                Thread.Sleep(20);
                Console.ForegroundColor=ConsoleColor.White;
            }
            Console.WriteLine();
        }
        static void Print(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Random r = new Random();
                Console.ForegroundColor = (ConsoleColor)r.Next(1, 14);
                Console.Write(text.Substring(i, 1));
                Thread.Sleep(20);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void PrintY()
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
