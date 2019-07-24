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
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Wildflower");
            Console.WriteLine("3. Sunflower");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            try
            {
                switch (Int32.Parse(choice))
                {
                    case 1:
                        ChoosePlowingField.CollectInput(farm, new Sesame());
                        break;
                    case 2:
                        ChooseNaturalField.CollectInput(farm, new Wildflower());
                        break;
                             case 3:
                   {
                       Console.Clear();
                       Console.WriteLine();
                       Console.WriteLine();
                       Console.WriteLine("1. Plowed Field");
                       Console.WriteLine("2. Natural Field");
                       Console.WriteLine();
                       Console.WriteLine("Choose What type of Field to plant your Sunflowers in:");
                       Console.Write("> ");
                       string fieldType = Console.ReadLine();
                       switch (Int32.Parse(fieldType))
                       {
                           case 1:
                               ChoosePlowingField.CollectInput(farm, new Sunflower());
                               break;
                           case 2:
                               ChooseNaturalField.CollectInput(farm, new Sunflower());
                               break;
                           default:
                               break;
                       }
                       break;
                   }
               default:
                   break;
                }
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(@"
                                   .-'`/\
                                 // /' /\`\
    Shucks that didn't work     ('//.-'/`-.;
                                 \ \ / /-.
              __.__.___..__._.___.\\ \\----,_ 
           .:{@&#,&#@&,@&#&&,#&@#&@&\\` \-. .-'-. 
        .:{@#@,#@&#,@#&&#,@&#&@&,&@#&&\\, -._,- \
      .{#@#&@#@#&#&@&#@#@&#,@#@#&@&&#@#\ \// = \`=\__
      `{#@,@#&@&,@&#@,#@&#@#&@#&@,&#@,#/\/ =`-. -_=__
        `:{@#&@&#@&#@&#@,#&&#@&,@#/.'  / / /.-', /
           `:{@#&,#&@#,@&#&@&,@&#/.-// //-'-_= ,/
              `~`~~`~~~`~`~`~~`~( / , /__,___.-
    Sorry for the corny joke...  \ \\/  
                                  `\\\'

");
                Console.WriteLine();
                Console.WriteLine("Please select an available stock option");
                PurchaseSeeds.CollectInput(farm);
            }
        }
    }
}