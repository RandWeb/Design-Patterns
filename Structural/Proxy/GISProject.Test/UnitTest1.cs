namespace GISProject.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var gisService = new GISServiceProxy();

            gisService.GetLatLng("Rasht");
            gisService.GetLatLng("Rasht");

            gisService.GetLatLng("Qom");

            gisService.GetLatLng("Tehran");
        }
    }
}