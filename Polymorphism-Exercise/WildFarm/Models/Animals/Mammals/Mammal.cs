namespace WildFarm.Models.Animals.Mammals
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight) : base(name, weight)
        {
        }

        protected Mammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }
        public string LivingRegion { get; }
    }
}
