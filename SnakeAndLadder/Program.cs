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
           
            //UC1 initialize the position of the player
            int position = 0;
            
            //UC2 Random roller die number 
            Random random = new Random();
            int die = random.Next(1, 7);
            position = position + die;
            Console.WriteLine("The value on rolling die is : "+die);
            Console.WriteLine("Player Position is : "+position);
            Console.ReadLine();
        }
    }
}
