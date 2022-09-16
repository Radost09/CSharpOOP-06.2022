using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private Dictionary<string, double> flourTypeCalories = new Dictionary<string, double>()
        {
            { "white", 1.5 },
            { "wholegrain", 1.0 }
        };
        private Dictionary<string, double> backingTechniqueCalories = new Dictionary<string, double>()
        {
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1.0 }
        };

        private const int CaloriesPerGram = 2;

        private string flourType;
        private string backingTechnique;
        private double weight;

        public Dough(string flourType, string backingTechnique, double weight)
        {
            this.FlourType = flourType;
            this.BackingTechnique = backingTechnique;
            this.Weight = weight;
        }

        public string FlourType 
        { 
            get
            {
                return this.flourType;
            }
            set
            {
                if(!flourTypeCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourType = value;
            }
        }
        public string BackingTechnique 
        { 
            get
            {
                return this.backingTechnique;
            }
            set
            {
                if(!backingTechniqueCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.backingTechnique = value;
            }
        }
        public double Weight 
        { 
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }
        public double Calories =>
            CaloriesPerGram * Weight * flourTypeCalories[this.FlourType.ToLower()] *
            backingTechniqueCalories[this.BackingTechnique.ToLower()];
    }
}
