using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class ChooseFieldType
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Plowed Field");
            Console.WriteLine("2. Natural Field");

            Console.WriteLine();
            Console.WriteLine("Where are you planting it?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            try
            {
                switch (Int32.Parse(choice))
                {
                    case 1:
                        ChooseFieldType.CollectInput(farm, new PlowingField());
                        break;
                    case 2:
                        ChooseFieldType.CollectInput(farm, new NaturalField());
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(@"
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
        |T||r||e||s||t||l||e||b||r||i||d||g||e|
        +-++-++-++-++-++-++-++-++-++-++-++-++-+
                    |F||a||r||m||s|
                    +-++-++-++-++-+");
                Console.WriteLine();
                Console.WriteLine("Please select an available stock option");
                PurchaseSeeds.CollectInput(farm);
            }
        }
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