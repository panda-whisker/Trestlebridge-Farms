using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Goat : IResource, IGrazing, ICompost
    {

        private Guid _id = Guid.NewGuid();
        private double _compost = 7.5;

        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 4.1;
        public string Type { get; } = "Goat";

        // Methods
        public void Graze()
        {
            Console.WriteLine($"Goat {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public override string ToString()
        {
            return $"Goat {this._shortId}. AHHHHHHHH!";
        }

        public double Compost()
        {
            return _compost;
        }
    }
}