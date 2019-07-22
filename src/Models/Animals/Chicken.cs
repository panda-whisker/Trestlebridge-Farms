using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IResource, IHousable, IMeatProducing
    {

        private Guid _id = Guid.NewGuid();
        private int _eggProduced = 6;
        private double _featherProduced = 0.75;



        private string _shortId
        {
            get
            {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 0.8;
        public string Type { get; } = "Chicken";

        // Methods
        public void Eat()
        {
            Console.WriteLine($"Chicken {this._shortId} just ate {this.FeedPerDay}kg of grass");
        }

        // public double Butcher()
        // {
        //     return _feedProduced;
        // }

        public override string ToString()
        {
            return $"Duck {this._shortId}. kwaaaaak!";
        }

        public double Butcher()
        {
            throw new NotImplementedException();
        }
    }
}