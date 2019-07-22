using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IMeatProducing>
    {
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

        private List<IMeatProducing> _animals = new List<IMeatProducing>()
        {

        };

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IMeatProducing animal)
        {
            // Add animal to List or return user to facility list in terminal
            try
            {
                _animals.Add(animal);
            }
            catch
            {
                Console.WriteLine("Press return to choose a different facility");
            }
        }

        public void AddResource(List<IMeatProducing> animals)
        {
            // TODO: implement this...

            // throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Chicken House ID# {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}