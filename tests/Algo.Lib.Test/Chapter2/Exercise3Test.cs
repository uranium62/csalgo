namespace Algo.Lib.Test.Chapter2
{
    using System.Collections.Generic;
    using Lib.Chapter2;
    using Xunit;

    public class Exercise3Test
    {
        [Fact]
        public void Remove_a_node_form_linked_list()
        {
            var lst = new LinkedList<int>();
            lst.AddLast(1);
            lst.AddLast(2);
            lst.AddLast(3);
            lst.AddLast(4);
            lst.AddLast(5);

            var res = Exercise3.DeleteNode(lst, lst.First.Next);

            Assert.True(res);
        }
    }
}
