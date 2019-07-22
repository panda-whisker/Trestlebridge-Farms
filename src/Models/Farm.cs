using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<DuckHouse> DuckHouses { get; } = new List<DuckHouse>();

        public List<ChickenHouse> ChickenHouses { get; } = new List<ChickenHouse>();

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T>(IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                case "Chicken":
                    ChickenHouses[index].AddResource((IHousable)resource);
                    break;
                case "Duck":
                    ChickenHouses[index].AddResource((IHousable)resource);
                    break;
                    
                default:
                    break;
            }
        }

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
            // Confirmation 
            System.Console.WriteLine($"{field} has been added");
        }
        public void AddDuckHouse(DuckHouse field)
        {
            
            // Confirmation 
            System.Console.WriteLine($"{field} has been added");
        }

        public void AddChickenHouse(ChickenHouse house)
        {
            ChickenHouses.Add(house);
            // Confirmation 
            System.Console.WriteLine($"{house} has been added");
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            DuckHouses.ForEach(dh => report.Append(dh));

            ChickenHouses.ForEach(ch => report.Append(ch));

            return report.ToString();
        }
    }
}