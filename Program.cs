using System;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\nWelcome to RetroRPG");

            Console.Write("Player 1, please press a key to represent your player: ");
            char playerSprite = Console.ReadKey().KeyChar;
            players.Add(new Player(playerSprite));
            Console.Write("\nPlayer 2, please press a key to represent your player: ");
            playerSprite = Console.ReadKey().KeyChar;
            Console.WriteLine("\nPress any key to begin");
            Console.ReadLine();
            players.Add(new Player(playerSprite, ConsoleColor.DarkMagenta));

            Console.Clear();
            Draw(players);

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

                    players[0].Move(direction);
                    players[1].Move(direction2);

                }

                Console.Clear();
                Draw(players);
            

                Thread.Sleep(1000/30);
            }
        }
        public static void Draw(List<Player> players)
        {

           foreach(Player player in players)
            {
                player.Draw();
            }
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
