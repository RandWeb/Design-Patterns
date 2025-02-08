// See https://aka.ms/new-console-template for more information
public class Car(ICarEngine carEngine)
{
    private readonly ICarEngine _engine = carEngine;

    public void StartEngine()
    {
        _engine.Start();
    }
}
