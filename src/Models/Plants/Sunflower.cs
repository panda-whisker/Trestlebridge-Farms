using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ISeedProducing, ICompost
    {
        private int _seedsProduced = 650;

        private double _compostProduced = 21.6;
        public string Type { get; } = "Sunflower";

        public double Harvest()
        {
            return _seedsProduced;
        }

        public override string ToString()
        {
            return $"Sunflower. Yum!";
        }

        public double Compost()
        {
            return _compostProduced;
        }
    }
}