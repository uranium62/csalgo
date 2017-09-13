namespace Algo.Lib.Test.Chapter4
{
    using Lib.Chapter4;
    using Xunit;

    public class Exercise5Test
    {
        [Fact]
        public void Check_BST_tree()
        {
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4, null, node5);
            var node2 = new BinaryTreeNode<int>(2);
            var node1 = new BinaryTreeNode<int>(1, null, node2);
            var node3 = new BinaryTreeNode<int>(3, node1, node4);
            var root = node3;

            var isBst = Exercise5.IsBST(root);

            Assert.True(isBst);
        }

        [Fact]
        public void Check_not_BST_tree()
        {
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4, null, node5);
            var node2 = new BinaryTreeNode<int>(8);
            var node1 = new BinaryTreeNode<int>(1, null, node2);
            var node3 = new BinaryTreeNode<int>(3, node1, node4);
            var root = node3;

            var isBst = Exercise5.IsBST(root);

            Assert.False(isBst);
        }
    }
}
