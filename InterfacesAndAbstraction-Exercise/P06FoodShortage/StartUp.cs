
namespace P06FoodShortage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyerList = new Dictionary<string, IBuyer>();
            int numOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfPeople; i++)
            {
                string[] buyerInfo = Console.ReadLine().Split(' ');

                if(buyerInfo.Length == 4)
                {
                    string name = buyerInfo[0];
                    int age = int.Parse(buyerInfo[1]);
                    string id = buyerInfo[2];
                    string bDay = buyerInfo[3];
                    IBuyer citizen = new Citizen(name, age, id, bDay);
                    buyerList[name] = citizen;
                }
                else if(buyerInfo.Length == 3)
                {
                    string name = buyerInfo[0];
                    int age = int.Parse(buyerInfo[1]);
                    string group = buyerInfo[2];
                    IBuyer rebel = new Rebel(name, age, group);
                    buyerList[name] = rebel;
                }
            }
            string buyerName = Console.ReadLine();
            while(buyerName != "End")
            {
                if(buyerList.ContainsKey(buyerName))
                {
                    buyerList[buyerName].BuyFood();
                }
                buyerName = Console.ReadLine();
            }
            int totalFoodBought = buyerList.Values.Sum(x => x.Food);
            Console.WriteLine(totalFoodBought);
        }
    }
}
