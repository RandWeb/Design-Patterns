namespace PhoneGenerator;
//Concrete Class
public class GLX : ICellPhoneBuilder
{
    private CellPhone _phone;

    public GLX()
    {
        _phone = new CellPhone();
    }

    public void AddBody()
    {
        _phone.BodyMaterial = "body GlX";
    }

    public void AddCamera()
    {
        _phone.CameraResolution = "Camera GlX";
    }

    public void AddMonitorSize()
    {
        _phone.MonitorSize = "Monitor GLX";
    }

    public void AddOS()
    {
        _phone.OSName = "TOF";
    }

    public CellPhone Build()
    {
        return _phone;
    }
}
