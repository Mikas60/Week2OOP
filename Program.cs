using System;
using System.Threading;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player player1 = new Player();
            Player player2 = new Player();

            Console.WriteLine("Hello Fabio!");
            Console.WriteLine();

            Console.Clear();
            player1.Draw();
            player2.Draw();

            while(true)
            {

                if(Console.KeyAvailable)
                {
                    string direction = "";
                    string direction2 = "";

                    ConsoleKeyInfo keyPress = Console.ReadKey(true);
                    
                    if(keyPress.Key == ConsoleKey.UpArrow)
                    {
                        direction = "up";
                    }
                    else if(keyPress.Key == ConsoleKey.DownArrow)
                    {
                        direction = "down";
                    } 
                    else if(keyPress.Key == ConsoleKey.LeftArrow)
                    {
                        direction = "left";
                    }
                    else if(keyPress.Key == ConsoleKey.RightArrow)
                    {
                        direction = "right";
                    }
                    else if(keyPress.Key == ConsoleKey.W)
                    {
                        direction2 = "up";
                    }
                    else if(keyPress.Key == ConsoleKey.S)
                    {
                        direction2 = "down";
                    } 
                    else if(keyPress.Key == ConsoleKey.A)
                    {
                        direction2 = "left";
                    }
                    else if(keyPress.Key == ConsoleKey.D)
                    {
                        direction2 = "right";
                    }

                    player1.Move(direction);
                    player2.Move(direction2);

                }

                Console.Clear();
                player1.Draw();
                player2.Draw();

                Thread.Sleep(1000/60);
            }
        }
    }
}
