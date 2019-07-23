using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;
using System.Collections.Generic;

namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            var fullGrazingFields = new List<int>();
            // Make a list of available fields
            Console.Clear();
            for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                if (farm.GrazingFields[i].AnimalCount < farm.GrazingFields[i].Capacity)
                {
                    // Calculate Animal Count By Type
                    var typesList = (from creature in farm.GrazingFields[i].AnimalsList
                                     group creature by creature.Type into g
                                     let count = g.Count()
                                     select new { Value = g.Key, Count = count });



                    // Print Message
                    Console.WriteLine($"{i + 1}. Grazing Field {farm.GrazingFields[i].id} has {farm.GrazingFields[i].AnimalCount} animals");
                    if (farm.GrazingFields[i].AnimalCount > 0)
                    {
                        foreach (var type in typesList)
                        {
                            Console.WriteLine($"     {type.Value}:  {type.Count}");
                        }
                    }
                }
                else
                {
                    fullGrazingFields.Add(i);
                    // Console.WriteLine("Please select an available facility option");
                    // CreateFacility.CollectInput(farm);
                };
            }
            if (fullGrazingFields.Count == farm.GrazingFields.Count)
            {
                Console.WriteLine("Please create a new facility");
                CreateFacility.CollectInput(farm);
            }
            else
            {
                Console.WriteLine($"Place the animal where?");
                Console.Write("> ");
                int choice = Int32.Parse(Console.ReadLine());
                if (farm.GrazingFields[choice - 1].AnimalCount < farm.GrazingFields[choice - 1].Capacity)
                {
                    farm.GrazingFields[choice - 1].AddResource(animal);
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




