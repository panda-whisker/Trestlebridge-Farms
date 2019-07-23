using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using System.Collections.Generic;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IHousable animal)
        {
            var fullDuckHouses = new List<int>();
            // Make a list of available duck houses
            Console.Clear();
            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                if (farm.DuckHouses[i].AnimalCount < farm.DuckHouses[i].Capacity)
                {
                    // Print Message
                    Console.WriteLine($"{i + 1}. Duck House  {farm.DuckHouses[i].id} has {farm.DuckHouses[i].AnimalCount} ducks");
                }
                else
                {
                    fullDuckHouses.Add(i);
                };
                if (fullDuckHouses.Count == farm.DuckHouses.Count)
                {
                    Console.WriteLine("Please create a new facility");
                    CreateFacility.CollectInput(farm);
                }
                else
                {
                    Console.WriteLine($"Place the animal where?");

                    Console.Write("> ");
                    int choice = Int32.Parse(Console.ReadLine());
                    if (farm.DuckHouses[choice - 1].AnimalCount < farm.DuckHouses[choice - 1].Capacity)
                    {
                        farm.DuckHouses[choice - 1].AddResource(animal);
                    }
                    else
                    {
                        // Console.WriteLine("This duck house if full");
                        Console.WriteLine("Please select an available facility option");
                        CreateFacility.CollectInput(farm);
                    }
                    Console.WriteLine();
                }
            }

            // How can I output the type of animal chosen here?
            // Console.WriteLine($"Place the animal where?");

            // Console.Write("> ");
            // int choice = Int32.Parse(Console.ReadLine());
            // try
            // {
            //     farm.DuckHouses[choice - 1].AddResource(animal);
            // }
            // catch
            // {
            //     Console.WriteLine("Please press return and choose a different facility");
            // }

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}