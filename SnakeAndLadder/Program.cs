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
            int position = 0 , die = 0 , count =0 ;
            
            //UC2 Random roller die number 
            Random random= new Random();
            
            // UC4 Check until the winning psition 100
            while (position < 100)
            {
                die = random.Next(1, 7);

                // UC3 Check No Play ,Ladder and Snake Option
                int check = random.Next(0, 3);
                if (check == 1)
                {
                    Console.WriteLine("\nLadder");
                    position = position + die;
                    // UC5 Stay at privious position till the player get exact number
                    if (position > 100)
                    {
                        position = position - die;  
                    }
                    else if(position == 100)
                    {
                        Console.WriteLine("Player has won");
                    }
                    Console.WriteLine("Die:{0}   Position:{1}  ", die, position);
                    count++;
                }
                else if (check == 2)
                {
                    Console.WriteLine("\nSnake");
                    
                    position = position - die;
                    if (position < 0)
                    {
                        position = 0;
                    }
                    Console.WriteLine("Die:{0}   Position:{1}  ", die, position);
                    count++;
                }

                else
                {
                    Console.WriteLine("\nNo Play");
                    Console.WriteLine("Player is at position : " + position);
                }
            }
            Console.WriteLine("Die count to win the game is : "+count);
            Console.ReadLine();
        }
    }
}
