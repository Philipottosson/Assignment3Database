using labb3PhilipOttosson.Models;
using System;

namespace labb3PhilipOttosson
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1 - Add new playlist");
                Console.WriteLine("2 - Remove playlist");
                Console.WriteLine("3 - Modify existing playlist");
                Console.WriteLine("4 - Exit");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Please press press 1, 2, 3 or 4\nfor your selected option");
                var selectedOption = Console.ReadKey();

                switch (selectedOption.Key)
                {
                    case ConsoleKey.D1:
                        SQLAdapterPlaylist.AddPlaylist();
                        break;

                    case ConsoleKey.D2:
                        SQLAdapterPlaylist.RemovePlaylist();
                        break;

                    case ConsoleKey.D3:
                        SQLAdapterPlaylist.ModifyPlaylist();
                        break;
                    case ConsoleKey.D4:
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
    }
}
