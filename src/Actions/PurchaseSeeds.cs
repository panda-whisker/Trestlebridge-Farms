using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;
namespace Trestlebridge.Actions
{
    public class PurchaseSeeds
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Sunflower");
            Console.WriteLine("2. Wildflower");
            Console.WriteLine("3. Sesame");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            try
            {
                switch (Int32.Parse(choice))
                {
                    case 1:
                        ChooseFieldType.CollectInput(farm, new Sunflower());
                        break;
                    case 2:
                        ChooseNaturalField.CollectInput(farm, new Wildflower());
                        break;
                    case 3:
                        ChoosePlowingField.CollectInput(farm, new Sesame());
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
    }
}