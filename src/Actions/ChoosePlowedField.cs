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
        public static void CollectInput(Farm farm, ISeedProducing animal)
        {
            var fullPlowedFields = new List<int>();
            // Make a list of available fields
            Console.Clear();
            for (int i = 0; i < farm.PlowingFields.Count; i++)
            {
                if (farm.PlowingFields[i].PlantCount < farm.PlowingFields[i].Capacity)
                {
                    // Calculate Animal Count By Type
                    var typesList = (from creature in farm.PlowingFields[i].PlantsList
                                     group creature by creature.Type into g
                                     let count = g.Count()
                                     select new { Value = g.Key, Count = count });



                    // Print Message
                    Console.WriteLine($"{i + 1}. Plowing Field {farm.PlowingFields[i].id} has {farm.PlowingFields[i].PlantCount} Plants");
                    if (farm.PlowingFields[i].PlantCount > 0)
                    {
                        foreach (var type in typesList)
                        {
                            Console.WriteLine($"     {type.Value}:  {type.Count}");
                        }
                    }
                }
                else
                {
                    fullPlowedFields.Add(i);
                    // Console.WriteLine("Please select an available facility option");
                    // CreateFacility.CollectInput(farm);
                };
            }
            if (fullPlowedFields.Count == farm.PlowingFields.Count)
            {
                Console.WriteLine("Please create a new facility");
                CreateFacility.CollectInput(farm);
            }
            else
            {
                Console.WriteLine($"Place the animal where?");
                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());
                if (farm.PlowingFields[choice - 1].PlantCount < farm.PlowingFields[choice - 1].Capacity)
                {
                    farm.PlowingFields[choice - 1].AddResource(animal);
                }
                else
                {
                    // Console.WriteLine("This field is full ");
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




