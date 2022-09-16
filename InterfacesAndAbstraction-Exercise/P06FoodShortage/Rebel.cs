namespace P06FoodShortage
{
    public class Rebel : IBuyer
    {
        private const int DefaultFoodQuantity = 5;

        private string name;
        private int age;
        private string group;
        private int food = 0;
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Name 
        { 
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age 
        { 
            get { return this.age; }
            set { this.age = value; }
        }
        public string Group 
        { 
            get { return this.group; }
            set { this.group = value; }
        }

        public int Food => food;

        public void BuyFood()
        {
            this.food += DefaultFoodQuantity;
        }
    }
}
