using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, ICompost plant)
        {
            var fullNaturalFields = new List<int>();
            // Make a list of available fields
            Console.Clear();
            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                if (farm.NaturalFields[i].PlantCount < farm.NaturalFields[i].Capacity)
                {
                    // Calculate Plant Count By Type
                    var typeList = (from p in farm.NaturalFields[i].PlantsList
                                    group p by p.Type into g
                                    let count = g.Count()
                                    select new { Value = g.Key, Count = count });

                    // Print Message
                    Console.WriteLine($"{i + 1}. Natural Field {farm.NaturalFields[i].id} has {farm.NaturalFields[i].PlantCount} plant rows");
                    if (farm.NaturalFields[i].PlantCount > 0)
                    {
                        foreach (var type in typeList)
                        {
                            Console.WriteLine($"     {type.Value}: {type.Count}");
                        }
                    }
                }
                else
                {
                    fullNaturalFields.Add(i);
                };
            }
            if (fullNaturalFields.Count == farm.NaturalFields.Count)
            {
                Console.WriteLine("Please create a new facility");
                CreateFacility.CollectInput(farm);
            }
            else
            {
                Console.WriteLine($"Plant the seeds where?");
                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());
                if (farm.NaturalFields[choice - 1].PlantCount < farm.NaturalFields[choice - 1].Capacity)
                {
                    farm.NaturalFields[choice - 1].AddResource(plant);
                }
                else
                {
                    Console.WriteLine("Please select an available facility option");
                    CreateFacility.CollectInput(farm);
                }
                Console.WriteLine();
                // How can I output the type of seeds chosen here?
                /*
                    Couldn't get this to work. Can you?
                    Stretch goal. Only if the app is fully functional.
                 */
                // farm.PurchaseResource<IGrazing>(animal, choice);
            }
        }
    }
}