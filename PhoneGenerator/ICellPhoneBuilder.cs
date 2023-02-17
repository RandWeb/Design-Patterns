namespace PhoneGenerator;

//Builder
public interface ICellPhoneBuilder
{
    void AddMonitorSize();

    void AddBody();

    void AddCamera();

    void AddOS();

    CellPhone Build();
}
