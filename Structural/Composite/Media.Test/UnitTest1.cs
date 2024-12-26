namespace Media.Test;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var music1 = new Music("music 1");
        var music2 = new Music("music 2");
        var media = new MediaFolder("title");

        media.Add(music1);
        media.Add(music2);
        media.Play();
    }
}
