namespace P06FoodShortage
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        private const int DefaultFoodQuantity = 10;

        private string name;
        private int age;
        private string id;
        private string birthdate;
        private int food = 0;
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
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

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Birthdate
        {
            get { return this.birthdate; }
            set { this.birthdate = value; }
        }
        public int Food => food;
        public void BuyFood()
        {
            this.food += DefaultFoodQuantity;
        }
    }
}
