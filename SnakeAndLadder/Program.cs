using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Snake and Ladder Program");

            int position = 0;
            Random random= new Random();
            int die = random.Next(1, 7);
            Console.WriteLine("The value on rolling die : "+die);
            Console.ReadLine();
        }
    }
}
