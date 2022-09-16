using System;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string[] doughInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string doughType = doughInfo[1];
                string doughBackingType = doughInfo[2];
                double doughWeight = double.Parse(doughInfo[3]);
                Dough dough = new Dough(doughType, doughBackingType, doughWeight);

                string pizzaType = pizzaInfo[1];

                Pizza pizza = new Pizza(pizzaType, dough);

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] toppingInput = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string toppingType = toppingInput[1];
                    double toppingWeight = double.Parse(toppingInput[2]);
                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddToppings(topping);
                }
                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories():f2} Calories.");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
