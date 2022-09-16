using System;
using System.Collections.Generic;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();
            string[] peopleInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var person in peopleInfo)
                {
                    string[] personInfo = person.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string personName = personInfo[0];
                    decimal personMoney = decimal.Parse(personInfo[1]);

                    Person newPerson = new Person(personName, personMoney);
                    peopleList.Add(newPerson);
                }

                List<Product> productsList = new List<Product>();
                string[] productsInfo = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                foreach (var product in productsInfo)
                {
                    string[] productInfo = product.Split('=', StringSplitOptions.RemoveEmptyEntries);
                    string productName = productInfo[0];
                    decimal productPrice = decimal.Parse(productInfo[1]);

                    Product newProduct = new Product(productName, productPrice);

                    productsList.Add(newProduct);
                }
                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] shoppingList = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    Person shopper = peopleList.Find(p => p.Name == shoppingList[0]);
                    Product productToBuy = productsList.Find(p => p.Name == shoppingList[1]);
                    shopper.AddProductToShoppingBag(productToBuy);

                    input = Console.ReadLine();
                }
                foreach (var person in peopleList)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
