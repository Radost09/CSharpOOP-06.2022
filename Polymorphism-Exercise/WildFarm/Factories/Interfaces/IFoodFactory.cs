namespace WildFarm.Factories.Interfaces
{
    using WildFarm.Models.Foods;
    public interface IFoodFactory
    {
        Food CreateFood(string type, int quantity);
    }
}
