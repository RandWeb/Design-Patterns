//Bridge
public interface IMotor
{
    void BurnFuel();
}

public abstract class Car(IMotor motor)
{
    public void Drive()
    {
        motor.BurnFuel();
    }
}

public class GazMotor : IMotor
{
    public void BurnFuel()
    {
        Console.WriteLine("Burn Gaz");
    }
}

public class PetrolMotor : IMotor
{
    public void BurnFuel()
    {
        Console.WriteLine("Burn benzin");
    }
}

public class HybridMotor : IMotor
{
    public void BurnFuel()
    {
        Console.WriteLine("Burn Gaz and Petrol");
    }
}

public class Pride(IMotor motor) : Car(motor)
{
}

public class Dena(IMotor motor) : Car(motor)
{
}