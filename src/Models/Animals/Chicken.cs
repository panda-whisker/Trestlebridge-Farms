using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IHousable, IMeatProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 7.25;

        public double EggProduced { get; } = 7;

        public double FeatherProduced { get; } = .5;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 0.9;
        public string Type { get; } = "Chicken";

        // Methods
        public void Eat()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Chicken {this._shortId}. Bawk!";
        }
    }
}