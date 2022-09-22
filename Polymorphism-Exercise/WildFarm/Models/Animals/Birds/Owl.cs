﻿namespace WildFarm.Models.Animals.Birds
{
    using System;
    using System.Collections.Generic;
    using WildFarm.Models.Foods;

    public class Owl : Bird
    {
        private const double OwlWeightMultiplier = 0.25;
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override IReadOnlyCollection<Type> PreferredFood
            => new List<Type> { typeof(Meat) }.AsReadOnly();

        protected override double WeightMultiplier
            => OwlWeightMultiplier;

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
