namespace Algo.Lib.Test.Chapter2
{
    using System.Collections.Generic;
    using Lib.Chapter2;
    using Xunit;

    public class Exercise1Test
    {
        [Fact]
        public void Remove_duplicates()
        {
            var lst = new LinkedList<int>();
            lst.AddLast(1);
            lst.AddLast(2);
            lst.AddLast(2);
            lst.AddLast(3);

            var res = Exercise1.RemoveDups(lst);

            var cur = res.First;
            for (int i = 1; i <= 3; i++)
            {
                Assert.Equal(i, cur.Value);
                cur = cur.Next;
            }
            Assert.Equal(cur, null);
        }
    }
}
