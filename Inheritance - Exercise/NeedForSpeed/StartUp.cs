using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle sportCar = new SportCar(70, 100);
            sportCar.Drive(8);
            Console.WriteLine(sportCar.Fuel);
            Console.WriteLine(sportCar.FuelConsumption);

            Vehicle familyCar = new FamilyCar(100, 150);
            familyCar.Drive(10);
            Console.WriteLine(familyCar.Fuel);
        }
    }
}
