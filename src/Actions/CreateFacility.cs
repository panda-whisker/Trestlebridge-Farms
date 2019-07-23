using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class CreateFacility
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Grazing field");
            Console.WriteLine("2. Plowed field");
            Console.WriteLine("3. Natural field");
            Console.WriteLine("4. Duck House");
            Console.WriteLine("5. Chicken House");

            Console.WriteLine();
            Console.WriteLine("Choose what you want to create");

            Console.Write("> ");
            string input = Console.ReadLine();

            try
            {
                switch (Int32.Parse(input))
                {
                    case 1:
                        farm.AddGrazingField(new GrazingField());
                        break;
                    case 2:
                        farm.AddPlowingField(new PlowingField());
                        break;
                    case 3:
                        farm.AddNaturalField(new NaturalField());
                        break;
                    case 4:
                        farm.AddDuckHouse(new DuckHouse());
                        break;
                    case 5:
                        farm.AddChickenHouse(new ChickenHouse());
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
                Console.WriteLine("Please select an available facility option");
                CreateFacility.CollectInput(farm);
            }
        }
    }
}