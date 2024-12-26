namespace ComputerStore;

//Product
public class AmdComputer : IComputerBuilder
{
    private Computer _computer;

    public AmdComputer()
    {
        _computer = new();
    }

    public void SetMotherBoard()
    {
        _computer.MotherBoard = "AmdMotherboard";
    }

    public void SetCpu()
    {
        _computer.Cpu = "AmdCpu";
    }

    public void SetRam()
    {
        _computer.Ram = "AmdRam";
    }

    public void SetHard()
    {
        _computer.Hard = "AmdHard";
    }

    public Computer Build()
    {
        return  _computer;
    }
}