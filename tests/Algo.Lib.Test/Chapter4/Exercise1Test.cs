namespace Algo.Lib.Test.Chapter4
{
    using Lib.Chapter4;
    using Xunit;

    public class Exercise1Test
    {
        [Fact]
        public void Check_a_balance_tree()
        {
            BinaryTreeNode<int> root = new BinaryTreeNode<int>(5);
            BinaryTreeNode<int> left = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> right = new BinaryTreeNode<int>(6);
            BinaryTreeNode<int> leftLeft = new BinaryTreeNode<int>(1);

            root.Left = left;
            root.Right = right;
            left.Left = leftLeft;

            bool isBalance = Exercise1.IsBalance(root);

            Assert.True(isBalance);
        }

        [Fact]
        public void Check_an_unbalance_tree()
        {
            BinaryTreeNode<int> root = new BinaryTreeNode<int>(5);
            BinaryTreeNode<int> left = new BinaryTreeNode<int>(3);
            BinaryTreeNode<int> right = new BinaryTreeNode<int>(6);
            BinaryTreeNode<int> rightRight = new BinaryTreeNode<int>(7);
            BinaryTreeNode<int> rightRightRight = new BinaryTreeNode<int>(8);

            root.Left = left;
            root.Right = right;
            right.Right = rightRight;
            rightRight.Right = rightRightRight;

            bool isBalance = Exercise1.IsBalance(root);

            Assert.False(isBalance);
        }
    }
}
