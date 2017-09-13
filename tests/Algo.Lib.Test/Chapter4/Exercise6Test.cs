namespace Algo.Lib.Test.Chapter4
{
    using Lib.Chapter4;
    using Xunit;

    class Exercise6Test
    {
        [Fact]
        public void Try_to_find_next_element()
        {
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4, null, node5);
            var node2 = new BinaryTreeNode<int>(2);
            var node1 = new BinaryTreeNode<int>(1, null, node2);
            var node3 = new BinaryTreeNode<int>(3, node1, node4);
            var root = node3;

            var node = Exercise6.InorderFindNext(root);

            Assert.Equal(node.Value, node4.Value);

        }
    }
}
