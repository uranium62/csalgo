using Algo.Lib.Chapter2;
using System.Collections.Generic;
using Xunit;

namespace Algo.Lib.Test.Chapter2
{
    public class Exercise6Test
    {
        [Fact]
        public void Find_loop_in_the_normal_list()
        {
            LinkedList<int> lst = new LinkedList<int>();
            lst.AddLast(0);
            lst.AddLast(1);
            lst.AddLast(2);
            lst.AddLast(3);
            lst.AddLast(4);

            var node = Exercise6.FindLoop(lst);

            Assert.Null(node);
        }
    }
}
