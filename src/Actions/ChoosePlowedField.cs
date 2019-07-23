using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;
using System.Collections.Generic;
namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {
        public static void CollectInput(Farm farm, ISeedProducing plant)
        {
            var fullPlowingField = new List<int>();
            // Make a list of available fields
            Console.Clear();
            for (int i = 0; i < farm.PlowingFields.Count; i++)
            {
                if (farm.PlowingFields[i].SeedCount < farm.PlowingFields[i].Capacity)
                {
                    Console.WriteLine($"{i + 1}. Plowed Field {farm.PlowingFields[i].id} has {farm.PlowingFields[i].SeedCount} plants");
                }
                else
                {
                    fullPlowingField.Add(i);
                    // Console.WriteLine("Please select an available facility option");
                    // CreateFacility.CollectInput(farm);
                };
            }
            if (fullPlowingField.Count == farm.PlowingFields.Count)
            {
                Console.WriteLine("Please create a new facility");
                CreateFacility.CollectInput(farm);
            }
            else
            {
                Console.WriteLine($"Place the Plant where?");
                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());
                if (farm.PlowingFields[choice - 1].SeedCount < farm.PlowingFields[choice - 1].Capacity)
                {
                    farm.PlowingFields[choice - 1].AddResource(plant);
                }
                else
                {
                    Console.WriteLine("This field is full ");
                    Console.WriteLine("Please select an available facility option");
                    CreateFacility.CollectInput(farm);
                }
                Console.WriteLine();
                // How can I output the type of animal chosen here?
                /*
                     Couldn't get this to work. Can you?
                     Stretch goal. Only if the app is fully functional.
                  */
                // farm.PurchaseResource<IGrazing>(animal, choice);
            }
        }
    }
}




