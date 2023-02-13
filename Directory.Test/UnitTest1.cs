namespace Directory.Test;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var file1 = new File(10);
        var file2 = new File(20);
        var file3 = new File(30);
        var composite1 = new Directory(file1, file2, file3);

        var composite2 = new Directory();
        composite2.AddFile(file1);
        composite2.AddFile(file2);
        composite2.AddFile(file3);

        Assert.AreEqual(composite2.Size(), composite1.Size());
    }
}
