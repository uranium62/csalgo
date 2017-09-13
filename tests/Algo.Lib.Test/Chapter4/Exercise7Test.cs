namespace Algo.Lib.Test.Chapter4
{
    using Lib.Chapter4;
    using Xunit;

    public class Exercise7Test
    {
        [Fact]
        public void Find_parent_in_the_binary_tree()
        {
            var node6 = new BinaryTreeNode<int>(6);
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4, node6, node5);
            var node2 = new BinaryTreeNode<int>(2);
            var node1 = new BinaryTreeNode<int>(1, null, node2);
            var node3 = new BinaryTreeNode<int>(3, node1, node4);
            var root = node3;

            var parent1 = Exercise7.FindParent(root, node6, node5);
            var parent2 = Exercise7.FindParent(root, node2, node5);
            
            Assert.Equal(parent1.Value, node4.Value);
            Assert.Equal(parent2.Value, node3.Value);
        }
    }
}
