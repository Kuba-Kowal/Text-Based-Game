using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Text_Based_Game
{
    internal class Program
    {

        public static List<string> inventory = new List<string>() {""};
        public static bool door12Entered = false;
        public static bool door13Entered = false;



        public static void Main(string[] args)
        {

            // Set Window Paramaters
            Console.Title = "Mushroom Kingdom";
            Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.DarkRed;

            // Starting The Game
            Console.WriteLine("                       .-'~~~-.\r\n                     .'o  oOOOo`.\r\n                    :~~~-.oOo   o`.\r\n                     `. \\ ~-.  oOOo.\r\n                       `.; / ~.  OO:\r\n                       .'  ;-- `.o.'\r\n                      ,'  ; ~~--'~\r\n                      ;  ;\r\n_______\\|/__________\\\\;_\\\\//___\\|/______________");
            Console.WriteLine("Welcome to the Mushroom Kingdom. Ready to begin?");
            Console.WriteLine("1. Begin");
            Console.WriteLine("2. Help");
            Console.WriteLine("3. Quit");


            while (true)
            {
                // Player Selection
                Console.Write("> ");
                string menuSelection = Console.ReadLine();

                if (Int32.Parse(menuSelection) == 1)
                {
                    Console.Clear();
                    Write("Welcome... To The Game.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    room1();
                }
                else if (Int32.Parse(menuSelection) == 2)
                {

                }

                else if (Int32.Parse(menuSelection) == 3)
                {
                    System.Environment.Exit(0);
                }
                // Stops Auto Close
                Console.ReadLine();

            }
        }



        public static void room1()
        {
            Console.Clear();
            Console.WriteLine("\n\nYou look around, Everythings moving. A single beam of light shining down into the endless hole. ");
            Console.WriteLine("The room has 4 doors. Which one would you like to enter.");
            Console.WriteLine("\n ==========+ \t\t\t\t ==========+ \t\t\t ==========+ \r\n|  __  __  ||\t\t\t\t|  __  __  ||\t\t\t|  __  __  ||\r\n| |  ||  | ||\t\t\t\t| |  ||  | ||\t\t\t| |  ||  | ||\r\n| |  12  | ||\t\t\t\t| |  13  | ||\t\t\t| |  14  | ||\r\n| |__||__| |--\t\t\t\t| |__||__| |--\t\t\t| |__||__| |--\r\n|  __  __()|\\ You Hear Screaming...\t|  __  __()|\\ You Hear Music... |  __  __()|\\ You Dont Hear Anything...\r\n| |  ||  | +|\t\t\t\t| |  ||  | +|\t\t\t| |  ||  | +|\r\n| |  ||  | ||\t\t\t\t| |  ||  | ||\t\t\t| |  ||  | ||\r\n| |  ||  | ||\t\t\t\t| |  ||  | ||\t\t\t| |  ||  | ||\r\n| |__||__| ||\t\t\t\t| |__||__| ||\t\t\t| |__||__| ||\r\n|__________|- \t\t\t     \t|__________|- \t \t\t|__________|-    ");
            Console.WriteLine("\nWhich Door would you like to enter");

            while (true)
            {

                Console.Write("> ");
                string menuSelection = Console.ReadLine();

                if (Int32.Parse(menuSelection) == 12)
                {
                    if (door12Entered == true)
                    {
                        Console.Clear();
                        Write("The door seems to be locked shut");
                        Thread.Sleep(1500);
                        Console.Clear();
                        room1();
                    }
                    door12();

                }

                else if (Int32.Parse(menuSelection) == 13)
                {
                    if (door13Entered == true)
                    {
                        Console.Clear();
                        Write("The door seems to be locked shut");
                        Thread.Sleep(1500);
                        Console.Clear();
                        room1();
                    }
                    door13();
                }
            }
        }



        public static void door12()
        {
            Console.Clear();
            Console.WriteLine("You enter the door...");
            Thread.Sleep(1500);
            Console.WriteLine("\nYou see a weapon radiating a powerful energy within the ground.");
            Console.WriteLine("(take) it or (leave)\n");

            while (true)
            {
                Console.Write("> ");
                string subMenuSelect = Console.ReadLine();

                if (subMenuSelect == "take")
                {
                    Console.Clear();
                    Console.WriteLine("Water drips onto your back\n");
                    Write("................................................................................");
                    Console.Clear();
                    Thread.Sleep(2000);
                    Console.WriteLine("                 ___-----------___\r\n           __--~~                 ~~--__\r\n       _-~~                             ~~-_\r\n    _-~                                     ~-_\r\n   /                                           \\\r\n  |                                             |\r\n |                                               |\r\n |                                               |\r\n|                                                 |\r\n|                                                 |\r\n|                                                 |\r\n |                                               |\r\n |  |    _-------_               _-------_    |  |\r\n |  |  /~         ~\\           /~         ~\\  |  |\r\n  ||  |             |         |             |  ||\r\n  || |               |       |               | ||\r\n  || |              |         |              | ||\r\n  |   \\_           /           \\           _/   |\r\n |      ~~--_____-~    /~V~\\    ~-_____--~~      |\r\n |                    |     |                    |\r\n|                    |       |                    |\r\n|                    |  /^\\  |                    |\r\n |                    ~~   ~~                    |\r\n  \\_         _                       _         _/\r\n    ~--____-~ ~\\                   /~ ~-____--~\r\n         \\     /\\                 /\\     /\r\n          \\    | ( ,           , ) |    /\r\n           |   | (~(__(  |  )__)~) |   |\r\n            |   \\/ (  (~~|~~)  ) \\/   |\r\n             |   |  [ [  |  ] ]  /   |\r\n              |                     |\r\n               \\                   /\r\n                ~-_             _-~\r\n                   ~--___-___--~\r\n                     You Died.");
                    Thread.Sleep(3500);
                    Console.Clear();
                    Main(null);
                }

                else if (subMenuSelect == "take" && inventory.Contains("hunterGloves"))
                {
                    Console.Clear();
                    Thread.Sleep(500);
                    Console.WriteLine("You sneakily grab the weapon out of its home and place it into your sheith. Your gloves get ruined in the process.");
                    inventory.Add("Mushy Machete");
                    inventory.Remove("hunterGloves");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("you leave the room and it locks shut behind you");
                    door12Entered = true;
                    room1();
                }

                else if (subMenuSelect == "leave")
                {
                    Console.Write("\n");
                    Write("Wise Decision");
                    Thread.Sleep(1000);
                    Console.Clear();

                    room1();
                }

                else
                {
                    Console.WriteLine("\nInvalid Choice.\n");
                }
            }
            
        }



        public static void door13()
        {
            Console.Clear();
            Console.WriteLine("You enter the door...");
            Thread.Sleep(1500);
            Console.WriteLine("There seems to be a locked chest linked to some form of puzzle. ");
            Console.WriteLine("(attempt) to solve it or (leave)\n");

            while (true)
            {
                Console.Write("> ");
                string subMenuSelect = Console.ReadLine();

                if (subMenuSelect == "attempt")
                {
                    door13Puzzle();
                }

                else if (subMenuSelect == "leave")
                {

                }

                else
                {
                    Console.WriteLine("\nInvalid Choice.\n");
                }
            }

        }



        public static void door13Puzzle()
        {

            //int locationy;
            //int locationx;



            string[,] map =
            {
                { "┌", "─", "─", "─", "─", "─", "─", "─", "─", "┐"},
                { "│", "x", "0", "0", "0", "0", "0", "0", "0", "│"},
                { "│", "x", "0", "x", "x", "x", "x", "x", "0", "│"},
                { "│", "o", "0", "x", "0", "0", "0", "x", "0", "│"},
                { "│", "x", "x", "x", "0", "x", "0", "x", "0", "│"},
                { "│", "x", "x", "x", "0", "x", "0", "x", "0", "│"},
                { "│", "█", "0", "0", "0", "x", "0", "0", "0", "│"},
                { "└", "─", "─", "─", "─", "─", "─", "─", "─", "┘"}
            };

            Console.Clear();
            Console.WriteLine("You look around the room and create a mental image of the puzzle.\n");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("\n");

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }

            Console.Clear();
            Console.WriteLine("Seems like someone has completed the puzzle for you.\n");
            Write("You open the chest and find some gloves, you put them on and leave. The door locks shut behind you.");
            door13Entered = true;
            inventory.Add("hunterGloves");
            Console.Write(inventory);
            Thread.Sleep(10000);
            room1();

        }



        public static void Write(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(80);
            }
        }
    }
}
