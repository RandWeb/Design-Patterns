namespace PhoneGenerator.Test;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var denaDirector = new CellPhoneDirector(new Dena());

        var dena = denaDirector.Create();

        var glxDirector = new CellPhoneDirector(new GLX());

        var glx = glxDirector.Create();

    }
}
