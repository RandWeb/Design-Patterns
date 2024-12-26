namespace PhoneGenerator;

//Director
public class CellPhoneDirector
{
    private ICellPhoneBuilder _builder;

    public CellPhoneDirector(ICellPhoneBuilder builder)
    {
        _builder = builder;
    }

    public CellPhone Create()
    {
        _builder.AddBody();
        _builder.AddMonitorSize();
        _builder.AddCamera();
        _builder.AddOS();

        return _builder.Build();
    }
}
