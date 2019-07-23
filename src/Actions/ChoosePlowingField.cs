using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChoosePlowingField
    {
        public static void CollectInput(Farm farm, ISeedProducing seed)
        {
            Console.Clear();

            for (int i = 0; i < farm.PlowingFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Plowing Field {farm.PlowingFields[i].id} has {farm.PlowingFields[i].SeedCount} seeds");
            }

            Console.WriteLine();

            // How can I output the type of seeds chosen here?
            Console.WriteLine($"Place the seeds where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.PlowingFields[choice - 1].AddResource(seed);


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}