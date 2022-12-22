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
<<<<<<< HEAD
            //UC1 initialize the position of the player
            int position = 0 , die =0;
            
            //UC2 Random roller die number 
            Random random= new Random();
            die = random.Next(1, 7);
            
            // UC3 Check No Play ,Ladder and Snake Option
            int check = random.Next(0, 3);
            if (check == 1)
            {
                Console.WriteLine("Ladder");
                position = position + die;
                Console.WriteLine("Die Number is {0} Player is at position {1}  ", die, position);
            }
            else if (check == 2)
            {
                Console.WriteLine("Snake");
                position = position - die;
                if (position < 0)
                    position = 0;
                Console.WriteLine("Die Number is {0} Player is at position {1}  ", die, position);
            }
            else
            {
                Console.WriteLine("No Play");
                Console.WriteLine("Player is at position : "+position);
            }
                

=======
           
            //UC1 initialize the position of the player
            int position = 0;
            
            //UC2 Random roller die number 
            Random random = new Random();
            int die = random.Next(1, 7);
            position = position + die;
            Console.WriteLine("The value on rolling die is : "+die);
            Console.WriteLine("Player Position is : "+position);
>>>>>>> RollTheDieUC2
            Console.ReadLine();
        }
    }
}
