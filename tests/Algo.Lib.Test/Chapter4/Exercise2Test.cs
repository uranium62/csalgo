namespace Algo.Lib.Test.Chapter4
{
    using Lib.Chapter4;
    using Xunit;

    public class Exercise2Test
    {

        [Fact]
        public static void Find_in_the_graph_correct_route()
        {
            /*      2
             *  1 -
             *      3 - 4 - 5
             */
            var node5 = new GraphNode<int>(5);
            var node4 = new GraphNode<int>(4, node5);
            var node3 = new GraphNode<int>(3, node4);
            var node2 = new GraphNode<int>(2);
            var node1 = new GraphNode<int>(1, node2, node3);

            var hasRoute1 = Exercise2.WidthSearch(node1, node1, node5);
            var hasRoute2 = Exercise2.WidthSearch(node1, node2, node5);

            Assert.True(hasRoute1);
            Assert.False(hasRoute2);
        }
    }
}
