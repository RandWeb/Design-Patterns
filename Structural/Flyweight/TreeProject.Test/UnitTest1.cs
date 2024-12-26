using TreeProject;

namespace TreeProject.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Tree> trees = new();

            var treeType = new TreeFactory()["pine", "green", "short"];
            var tree1 = new Tree(treeType, 1, 1);
            trees.Add(tree1);

            var treeType2 = new TreeFactory()["pine", "green", "short"];
            var tree2 = new Tree(treeType, 2, 2);
            trees.Add(tree2);

            var treeType3 = new TreeFactory()["pine", "green", "short"];
            var tree3 = new Tree(treeType, 3, 3);
            trees.Add(tree3);

            foreach(var tree in trees)
            {
                tree.Draw(tree);
            }
        }
    }
}