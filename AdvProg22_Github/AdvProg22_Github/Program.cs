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
            Console.WriteLine(yourName);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
