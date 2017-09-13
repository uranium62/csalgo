namespace Algo.Lib.Test.Chapter4
{
    using Lib.Chapter4;
    using Xunit;

    public class Exercise4Test
    {
        [Fact]
        public void Create_level_linked_list()
        {
            var node5 = new BinaryTreeNode<int>(5);
            var node4 = new BinaryTreeNode<int>(4, null, node5);
            var node2 = new BinaryTreeNode<int>(2);
            var node1 = new BinaryTreeNode<int>(1, null, node2);
            var node3 = new BinaryTreeNode<int>(3, node1, node4);
            var root  = node3;

            var lst = Exercise4.CreateLevelLinkedList(root);

            Assert.Equal(lst[0].Count, 1);
            Assert.Equal(lst[1].Count, 2);
            Assert.Equal(lst[2].Count, 2);
        }
    }
}
