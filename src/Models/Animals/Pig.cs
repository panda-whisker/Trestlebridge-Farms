using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Pig : IResource, IGrazing, IMeatProducing
    {

        private Guid _id = Guid.NewGuid();
        private double _meatProduced = 8.4;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 3.2;
        public string Type { get; } = "Pig";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Pig {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public double Butcher()
        {
            return _meatProduced;
        }

        public override string ToString()
        {
            return $"Pig {this._shortId}. Oink!";
        }
    }
}