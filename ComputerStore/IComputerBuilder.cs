namespace ComputerStore;

//Builder
public interface IComputerBuilder
{
    void SetMotherBoard();
    void SetCpu();
    void SetRam();
    void SetHard();
    Computer Build();
}