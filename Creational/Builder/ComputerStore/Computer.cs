namespace ComputerStore;

//Concrete Builder
public class Computer
{
    public string MotherBoard { get; set; }
    public string Cpu { get; set; }
    public string Ram { get; set; }
    public string Hard { get; set; }

    public override string ToString()
    {
        return $"Motherboard: {MotherBoard}\nCpu: {Cpu}\nRam:{Ram}\nHard: {Hard}";
    }
}