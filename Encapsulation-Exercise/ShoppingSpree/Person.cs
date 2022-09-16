using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
		private string name;
		private decimal money;
		private readonly List<Product> products;

		public Person(string name, decimal money)
		{
			this.Name = name;
			this.Money = money;
			this.products = new List<Product>();
		}
        public IReadOnlyCollection<Product> Products => products;
        public string Name
		{
			get 
			{ 
				return name; 
			}
			set 
			{
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value; 
			}
		}
        public decimal Money
        {
            get 
			{ 
				return money; 
			}
            set 
			{
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");

                }
                money = value; 
			}
        }
		public void AddProductToShoppingBag(Product product)
		{
			if(this.Money >= product.Cost)
			{
				this.products.Add(product);
				this.Money -= product.Cost;
				Console.WriteLine($"{this.Name} bought {product.Name}");
			}
			else
			{
				Console.WriteLine($"{this.Name} can't afford {product.Name}");
			}
		}
		public override string ToString()
		{
			StringBuilder output = new StringBuilder();
			if(Products.Count > 0)
			{
				output.AppendLine ($"{this.Name} - {string.Join(", ", products.Select(p => p.Name))}");
			}
			else
			{
				output.AppendLine ($"{this.Name} - Nothing bought");

            }
			return output.ToString().TrimEnd();
		}
	}
}
