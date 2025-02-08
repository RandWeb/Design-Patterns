namespace Design.DependencyInjection.CarExample;
internal class Playground
{
    public static void Run()
    {
        var diselCar = new Car(new DieselEngine());
        var petrolCar = new Car(new PetrolEngine());
    }
}
