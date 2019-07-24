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
            Console.WriteLine("3. Goat");
            Console.WriteLine("4. Sheep");
            Console.WriteLine("5. Pig");
            Console.WriteLine("6. Chicken");
            Console.WriteLine("7. Duck");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            try
            {
                switch (Int32.Parse(choice))
                {
                    case 1:
                        if (farm.GrazingFields.Count >= 1)
                        {
                            ChooseGrazingField.CollectInput(farm, new Cow());
                        }
                        else
                        {
                            Console.Clear();
                            System.Console.WriteLine("You haven't created a facility for this animal yet.");
                            CreateFacility.CollectInput(farm);
                        }
                        break;
                    case 2:
                        if (farm.GrazingFields.Count >= 1)
                        {
                            ChooseGrazingField.CollectInput(farm, new Ostrich());
                        }
                        else
                        {
                            Console.Clear();
                            System.Console.WriteLine("You haven't created a facility for this animal yet.");
                            CreateFacility.CollectInput(farm);
                        }
                        break;
                    case 3:
                        if (farm.GrazingFields.Count >= 1)
                        {
                            ChooseGrazingField.CollectInput(farm, new Goat());
                        }
                        else
                        {
                            Console.Clear();
                            System.Console.WriteLine("You haven't created a facility for this animal yet.");
                            CreateFacility.CollectInput(farm);
                        }
                        break;
                    case 4:
                        if (farm.GrazingFields.Count >= 1)
                        {
                            ChooseGrazingField.CollectInput(farm, new Sheep());
                        }
                        else
                        {
                            Console.Clear();
                            System.Console.WriteLine("You haven't created a facility for this animal yet.");
                            CreateFacility.CollectInput(farm);
                        }
                        break;
                    case 5:
                        if (farm.GrazingFields.Count >= 1)
                        {
                            ChooseGrazingField.CollectInput(farm, new Pig());
                        }
                        else
                        {
                            Console.Clear();
                            System.Console.WriteLine("You haven't created a facility for this animal yet.");
                            CreateFacility.CollectInput(farm);
                        }
                        break;
                    case 6:
                        if (farm.ChickenHouses.Count >= 1)
                        {
                            ChooseChickenHouse.CollectInput(farm, new Chicken());
                        }
                        else
                        {
                            Console.Clear();
                            System.Console.WriteLine("You haven't created a facility for this animal yet.");
                            CreateFacility.CollectInput(farm);
                        }
                        break;
                    case 7:
                        if (farm.DuckHouses.Count >= 1)
                        {
                            ChooseDuckHouse.CollectInput(farm, new Duck());
                        }
                        else
                        {
                            Console.Clear();
                            System.Console.WriteLine("You haven't created a facility for this animal yet.");
                            CreateFacility.CollectInput(farm);
                        }
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
                                
 _  _ _  _   ____ _  _ /
 |__| |--|   [__] |--|.    _
                        -=(')
                            ;;
                            //
                        //
                        : '.---.__
                        |  --_-_)__)
                        `.____,'
                            \  \
                        ___\  \
                        (       \
                                \    - There's been an Ost-glitch
                                /
 
                                
                                ");
                Console.WriteLine();
                Console.WriteLine("Please select an available stock option");
                PurchaseStock.CollectInput(farm);
            }
        }
    }
}