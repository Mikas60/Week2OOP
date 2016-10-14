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
            players.Add(new Player());
            players.Add(new Player());


            Console.WriteLine("Welcome to RetroRPG");
            Console.WriteLine("Press any key to begin");
            Console.ReadLine();

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
            

                Thread.Sleep(1000/60);
            }
        }
        public static void Draw(List<Player> players)
        {

           foreach(Player player in players)
            {
                player.Draw();
            }

        }
    }
}
