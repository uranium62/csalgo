namespace Algo.Lib.Test.Chapter2
{
    using System.Collections.Generic;
    using Lib.Chapter2;
    using Xunit;

    public class Exercise4Test
    {
        [Fact]
        public void Try_to_split_a_linked_list()
        {
            var lst = new LinkedList<int>();
            lst.AddLast(4);
            lst.AddLast(1);
            lst.AddLast(6);
            lst.AddLast(3);
            lst.AddLast(4);
            lst.AddLast(2);

            var splitter = 4;
            var isFoundSplitter = false;

            var res = Exercise4.Partition(lst, splitter);

            foreach (var x in res)
            {
                if (x == splitter && !isFoundSplitter)
                    isFoundSplitter = true;

                if (isFoundSplitter)
                    Assert.True(x >= splitter);
                else
                    Assert.True(x < splitter);
            }
        }
    }
}
