using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseNaturalField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();

            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Natural Field {farm.NaturalFields[i].id} has {farm.NaturalFields[i].AnimalCount} plants");
            }

            Console.WriteLine();

            // How can I output the type of seeds chosen here?
            Console.WriteLine($"Place the seeds where?");

            Console.Write("> ");
            int choice = Int32.Parse(Console.ReadLine());

            farm.NaturalFields[choice - 1].AddResource(animal);


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}