using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Facilities
{
    public class PlowingField : IFacility<ISeedProducing>
    {
        public double Capacity { get; } = 2;
        // public int AnimalCount
        // {
        //     get
        //     {
        //         return _animals.Count;
        //     }
        // }
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();
        public string id
        {
            get
            {
                string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
                return shortId;
            }
        }
        public string Type { get; }
        private List<ISeedProducing> _plant = new List<ISeedProducing>()
        {
        };

        public List<ISeedProducing> PlantsList
        {
            get
            {
                return _plant;
            }
        }
        public double PlantCount
        {
            get
            {
                return _plant.Count;
            }
        }
        // public static double Capacity
        // {
        //     get
        //     {
        //         return _capacity;
        //     }
        // }
        public void AddResource(ISeedProducing plant)
        {
            // Add plant to List or return user to facility list in terminal
            try
            {
                _plant.Add(plant);
            }
            catch
            {
                Console.WriteLine("Press return to choose a different facility");
            }
        }
        public void AddResource(List<ISeedProducing> plants)
        {
            // TODO: implement this...
            // throw new NotImplementedException();
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            output.Append($"Plowing field ID# {shortId} has {this._plant.Count} Plants\n");
            this._plant.ForEach(a => output.Append($"   {a}\n"));
            return output.ToString();
        }


    }
}