namespace Menu.Test;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var menu = new CompositeMenu("menu", 1);
        var menuItem11 = new Menu("test1", 1);
        var menuItem12 = new Menu("test2", 1);
        var menuItem13 = new Menu("test3", 1);
        menu.Add(menuItem11);
        menu.Add(menuItem12);
        menu.Add(menuItem13);

        var subMenuLevel1 = new CompositeMenu("submenu", 2);
        var menuItem21 = new Menu("test1", 2);
        var menuItem22 = new Menu("test2", 2);
        var menuItem23 = new Menu("test3", 2);
        subMenuLevel1.Add(menuItem21);
        subMenuLevel1.Add(menuItem22);
        subMenuLevel1.Add(menuItem23); 
        
        var subMenuLevel11 = new CompositeMenu("submenu2", 2);
        var menuItem211 = new Menu("test1", 2);
        var menuItem221 = new Menu("test2", 2);
        var menuItem231 = new Menu("test3", 2);
        subMenuLevel11.Add(menuItem211);
        subMenuLevel11.Add(menuItem221);
        subMenuLevel11.Add(menuItem231);

        var subMenuLevel2 = new CompositeMenu("submenu", 3);

        var menuItem31 = new Menu("test1", 3);
        var menuItem32 = new Menu("test2", 3);
        var menuItem33 = new Menu("test3", 3);
        subMenuLevel2.Add(menuItem31);
        subMenuLevel2.Add(menuItem32);
        subMenuLevel2.Add(menuItem33);

        menu.Add(subMenuLevel1);
        menu.Add(subMenuLevel11);
        subMenuLevel1.Add(subMenuLevel2);

        menu.Show();
    }
}
