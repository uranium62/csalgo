namespace Algo.Lib.Test.Chapter4
{
    using Lib.Chapter4;
    using Xunit;

    public class Exercise3Test
    {
        [Fact]
        public void Build_BST_tree()
        {
            int[] arr = new[] {1, 2, 3, 4, 5};

            var tree = Exercise3.CreateBST(arr);

            Assert.Equal(tree.Value, 3);
            Assert.Equal(tree.Left.Value, 1);
            Assert.Equal(tree.Left.Right.Value, 2);
            Assert.Equal(tree.Right.Value, 4);
            Assert.Equal(tree.Right.Right.Value, 5);
        }
    }
}
