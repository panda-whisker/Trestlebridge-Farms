using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;
namespace Trestlebridge.Actions
{
    public class ChooseGrazingField
    {
        public static void CollectInput(Farm farm, IGrazing animal)
        {
            Console.Clear();
         for (int i = 0; i < farm.GrazingFields.Count; i++)
            {
                if (farm.GrazingFields[i].AnimalCount <= farm.GrazingFields[i].Capacity)
                {
                    Console.WriteLine($"{i + 1}. Grazing Field {farm.GrazingFields[i].id} has {farm.GrazingFields[i].AnimalCount} animals");
                    Console.WriteLine($"Place the animal where?");
                    Console.Write("> ");
                    int choice = Int32.Parse(Console.ReadLine());
                farm.GrazingFields[choice - 1].AddResource(animal);
                }
                else { System.Console.WriteLine("This field is full"); }
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