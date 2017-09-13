namespace Algo.Lib.Test.Chapter4
{
    using Lib.Chapter4;
    using Xunit;

    public class Exercise8Test
    {
        [Fact]
        public void Has_subtree()
        {
            var node6 = new BinaryTreeNode<int>(6);
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4, node6, node5);
            var node2 = new BinaryTreeNode<int>(2);
            var node1 = new BinaryTreeNode<int>(1, null, node2);
            var node3 = new BinaryTreeNode<int>(3, node1, node4);
            var tree1 = node3;
            var tree2 = node4;

            var hasSubtree = Exercise8.Contains(tree1, tree2);

            Assert.True(hasSubtree);
        }
    }
}
