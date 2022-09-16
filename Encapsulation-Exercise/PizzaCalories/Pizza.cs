using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
		private const int ToppingCapacity = 10;
		//name, dough, and toppings
		private List<Topping> toppings;
		private Dough dough;
		private string name;

		public Pizza(string name, Dough dough)
		{
			this.Name = name;
			this.dough = dough;
			this.toppings = new List<Topping>();
		}
		public string Name
		{
			get 
			{ 
				return this.name; 
			}
			private set 
			{ 
				if(value.Length < 1 || value.Length > 15)
				{
					throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
				}
				this.name = value; 
			}
		}
		public void AddToppings(Topping topping)
		{
			if(toppings.Count >= ToppingCapacity)
			{
				throw new ArgumentException("Number of toppings should be in range [0..10].");
			}
			toppings.Add(topping);
		}
        public double GetTotalCalories()
        {
            double result = dough.Calories + toppings.Sum(x => x.Calories);

            return result;
        }
    }
}
