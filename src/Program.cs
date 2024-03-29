﻿using System;
using Trestlebridge.Actions;
using Trestlebridge.Models;

namespace Trestlebridge
{
    class Program
    {
        static void DisplayBanner()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(@"
        
        +-++-++-++-++-++-++-++-++-++-++-++-++-+          \|/          (__)    
        |T||r||e||s||t||l||e||b||r||i||d||g||e|               `\------(oo)
        +-++-++-++-++-++-++-++-++-++-++-++-++-+                 ||    (__)
                    |F||a||r||m||s|                             ||w--||     \|/
                    +-++-++-++-++-+                         \|/

        ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Farm Trestlebridge = new Farm();

            while (true)
            {
                DisplayBanner();
                Console.WriteLine("1. Create Facility");
                Console.WriteLine("2. Purchase Animals");
                Console.WriteLine("3. Purchase Seeds");
                Console.WriteLine("4. Display Farm Status");
                Console.WriteLine("5. Exit");
                Console.WriteLine();

                Console.WriteLine("Choose a FARMS option");
                Console.Write("> ");
                string option = Console.ReadLine();

                if (option == "1")
                {
                    DisplayBanner();
                    CreateFacility.CollectInput(Trestlebridge);
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                }
                else if (option == "2")
                {
                    DisplayBanner();
                    PurchaseStock.CollectInput(Trestlebridge);
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                }
                else if (option == "3")
                {
                    DisplayBanner();
                    PurchaseSeeds.CollectInput(Trestlebridge);
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                }
                else if (option == "4")
                {
                    DisplayBanner();
                    Console.WriteLine(Trestlebridge);
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("Press return key to go back to main menu.");
                    Console.ReadLine();
                }
                else if (option == "5")
                {
                    Console.WriteLine("Today is a great day for farming");
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid option: {option}");
                }
            }
        }
    }
}
