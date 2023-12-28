namespace ComputerStore;

public class Assembler
{
    private readonly IComputerBuilder _computerBuilder;

    public Assembler(IComputerBuilder computerBuilder)
    {
        _computerBuilder = computerBuilder;
    }

    public Computer Assembel()
    {
        _computerBuilder.SetMotherBoard();
        _computerBuilder.SetCpu();
        _computerBuilder.SetHard();
        _computerBuilder.SetRam();
        return _computerBuilder.Build();
    }
}