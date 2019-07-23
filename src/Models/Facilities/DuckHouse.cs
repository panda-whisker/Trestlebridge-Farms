using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IHousable>
    {
        public int AnimalCount
        {
            get
            {
                return _animals.Count;
            }
        }
        private int _capacity = 3;
        private Guid _id = Guid.NewGuid();

        public string id
        {
            get
            {
                string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
                return shortId;
            }
        }

        private List<IHousable> _animals = new List<IHousable>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IHousable animal)
        {
            // TODO: implement this...
            _animals.Add(animal);
        }

        public void AddResource(List<IHousable> animals)
        {
            // TODO: implement this...
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck house ID# {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}