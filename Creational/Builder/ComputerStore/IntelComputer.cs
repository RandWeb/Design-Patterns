namespace ComputerStore;

//Product
public class IntelComputer : IComputerBuilder
{
    private Computer _computer;

    public IntelComputer()
    {
        _computer = new();
    }

    public void SetMotherBoard()
    {
        _computer.MotherBoard = "IntelMotherboard";
    }

    public void SetCpu()
    {
        _computer.Cpu = "IntelCpu";
    }

    public void SetRam()
    {
        _computer.Ram = "IntelRam";
    }

    public void SetHard()
    {
        _computer.Hard = "IntelHard";
    }

    public Computer Build()
    {
        return _computer;
    }
}

//Director