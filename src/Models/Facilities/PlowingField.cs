using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowingField : IFacility<ISeedProducing>
    {
        public int SeedCount
        {
            get
            {
                return _seeds.Count;
            }
        }
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

        private List<ISeedProducing> _seeds = new List<ISeedProducing>()
        {

        };

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(ISeedProducing seed)
        {
            // Add seed to List or return user to facility list in terminal
            try
            {
                _seeds.Add(seed);
            }
            catch
            {
                Console.WriteLine("Press return to choose a different facility");
            }
        }

        public void AddResource(List<ISeedProducing> seeds)
        {
            // TODO: implement this...

            // throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowing field ID# {shortId} has {this._seeds.Count} seeds\n");
            this._seeds.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}