using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int CaloriesPerGram = 2;

        private Dictionary<string, double> TypeOfToppingCalories = new Dictionary<string, double>()
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };

        private string typeTopping;
        private double weight;
        public Topping(string typeTopping, double weight)
        {
            this.TypeTopping = typeTopping;
            this.Weight = weight;
        }
        public double Calories => CaloriesPerGram * this.Weight * TypeOfToppingCalories[this.TypeTopping.ToLower()];
        public string TypeTopping 
        { 
            get
            {
                return this.typeTopping;
            }
            set
            {
                if(!TypeOfToppingCalories.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.typeTopping = value;
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
                if(value < 1 || value > 50)
                {
                    throw new ArgumentException(
                        $"{nameof(this.TypeTopping)} weight should be in the range [1..50].");
                }
                this.weight = value;
            }
        }
    }
}
