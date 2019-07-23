using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;
using System.Collections.Generic;

namespace Trestlebridge.Actions
{
    public class ChooseChickenHouse
    {
        public static void CollectInput(Farm farm, IHousable animal)
        {
            var fullChickenHouses = new List<int>();
            // Make a list of available chicken houses
            Console.Clear();
            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                if (farm.ChickenHouses[i].AnimalCount < farm.ChickenHouses[i].Capacity)
                {
                    // Print Message
                    Console.WriteLine($"{i + 1}. Chicken House  {farm.ChickenHouses[i].id} has {farm.ChickenHouses[i].AnimalCount} chickens");
                }
                else
                {
                    fullChickenHouses.Add(i);
                };
                if (fullChickenHouses.Count == farm.ChickenHouses.Count)
                {
                    Console.WriteLine("Please create a new facility");
                    CreateFacility.CollectInput(farm);
                }
                else
                {
                    Console.WriteLine($"Place the animal where?");

                    Console.Write("> ");
                    int choice = Int32.Parse(Console.ReadLine());
                    if (farm.ChickenHouses[choice - 1].AnimalCount < farm.ChickenHouses[choice - 1].Capacity)
                    {
                        farm.ChickenHouses[choice - 1].AddResource(animal);
                    }
                    else
                    {
                        // Console.WriteLine("This chicken house is full");
                        Console.WriteLine("Please select an available facility option");
                        CreateFacility.CollectInput(farm);
                    }
                    Console.WriteLine();
                }
            }

            // How can I output the type of animal chosen here?

            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}