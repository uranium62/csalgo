namespace Algo.Lib.Test.Chapter2
{
    using System.Collections.Generic;
    using Lib.Chapter2;
    using Xunit;

    public class Exercise2Test
    {
        [Fact]
        public void Find_k_element_in_the_linked_list()
        {
            LinkedList<int> lst = new LinkedList<int>();
            lst.AddLast(1); // 6
            lst.AddLast(2); // 5
            lst.AddLast(3); // 4
            lst.AddLast(4); // 3
            lst.AddLast(5); // 2
            lst.AddLast(6); // 1

            var node1 = Exercise2.FindNodeFromEnd(lst, 5);
            var node2 = Exercise2.FindNodeFromEnd(lst, 6);
            var node3 = Exercise2.FindNodeFromEnd(lst, 1);
            var node4 = Exercise2.FindNodeFromEnd(lst, 7);

            Assert.Equal(node1.Value, 2);
            Assert.Equal(node2.Value, 1);
            Assert.Equal(node3.Value, 6);
            Assert.Null(node4);
        }
    }
}
