namespace WildFarm.Factories.Interfaces
{
    using WildFarm.Models.Animals;
    public interface IAnimalFactory
    {
        Animal CreateAnimal(string type, string name, double weight, string thirdParam, string fourthParam = null);
    }
}
