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
            int position1 = 0,position2 = 0 , die = 0 , count =1 ;
            
            //UC2 Random roller die number 
            Random random= new Random();

            // UC4 Check until the winning psition 100
            while (position1 < 100 && position2 < 100)
            {
                die = random.Next(1, 7);

                if (count % 2 == 0)
                {
                    // UC3 Check No Play ,Ladder and Snake Option
                    int check = random.Next(0, 2);
                    if (check == 1)
                    {
                        Console.WriteLine("\nLadder");
                        position1 = position1 + die;
                        // UC5 Stay at privious position till the player get exact number
                        if (position1 > 100)
                        {
                            position1 = position1 - die;
                        }
                        else if (position1 == 100)
                        {
                            Console.WriteLine("Player1 has won");
                        }
                        Console.WriteLine("Player1 is at Position:  " + position1);
                        count++;
                    }
                    else if (check == 2)
                    {
                        Console.WriteLine("\nSnake");

                        position1 = position1 - die;
                        if (position1 < 0)
                        {
                            position1 = 0;
                        }
                        Console.WriteLine("Player1 is at Position: " + position1);
                        count++;
                    }
                } 
                else
                {
                    int check = random.Next(0, 2);
                    if (check == 1)
                    {
                        Console.WriteLine("\nLadder");
                        position2 = position2 + die;
                        // UC5 Stay at privious position till the player get exact number
                        if (position2 > 100)
                        {
                            position2 = position2 - die;
                        }
                        else if (position2 == 100)
                        {
                            Console.WriteLine("Player2 has won");
                        }
                        Console.WriteLine("Player2 is at Position:  " + position2);
                        count++;
                    }
                    else if (check == 2)
                    {
                        Console.WriteLine("\nSnake");

                        position2 = position2 - die;
                        if (position2 < 0)
                        {
                            position2 = 0;
                        }
                        Console.WriteLine("Player2 is at Position: " + position2);
                        count++;
                    }
                }
            }
            Console.WriteLine("Die count to win the game is : "+count);
            Console.ReadLine();
        }
    }
}
