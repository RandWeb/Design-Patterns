namespace PhoneGenerator;

//Concrete Class
public class Dena : ICellPhoneBuilder
{
    private CellPhone _phone;

    public Dena()
    {
        _phone = new CellPhone();
    }

    public void AddBody()
    {
        _phone.BodyMaterial = "body Dena";
    }

    public void AddCamera()
    {
        _phone.CameraResolution = "Camera Dena";
    }

    public void AddMonitorSize()
    {
        _phone.MonitorSize = "Monitor Dena";
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
