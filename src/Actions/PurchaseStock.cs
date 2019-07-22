using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Cow");
            Console.WriteLine("2. Ostrich");
            Console.WriteLine("3. Chicken");
            Console.WriteLine("4. Duck");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            try
            {
                switch (Int32.Parse(choice))
                {
                    case 1:
                        ChooseGrazingField.CollectInput(farm, new Cow());
                        break;
                    case 2:
                        ChooseGrazingField.CollectInput(farm, new Ostrich());
                        break;
                    case 3:
                        ChooseChickenHouse.CollectInput(farm, new Chicken());
                        break;
                    case 4:
                        ChooseDuckHouse.CollectInput(farm, new Duck());
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
                PurchaseStock.CollectInput(farm);
            }
        }
    }
}