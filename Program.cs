using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Player player1 = new Player();

            Console.WriteLine("Hello Fabio!");
            Console.WriteLine();

            Console.Clear();
            player1.Draw();

            Console.ReadKey(true);
        }
    }
}
