using Algo.Lib.Chapter2;
using System.Collections.Generic;
using Xunit;

namespace Algo.Lib.Test.Chapter2
{
    public class Exercise5Test
    {
        [Fact]
        public void Sum_a_likned_list()
        {
            var lst1 = new LinkedList<int>();
            lst1.AddLast(9);
            lst1.AddLast(8);
            lst1.AddLast(7);
            var lst2 = new LinkedList<int>();
            lst2.AddLast(1);
            lst2.AddLast(6);

            var lst3 = Exercise5.Sum(lst1, lst2);

            Assert.True(lst3.First.Value == 1);
            Assert.True(lst3.First.Next.Value == 0);
            Assert.True(lst3.First.Next.Next.Value == 0);
            Assert.True(lst3.First.Next.Next.Next.Value == 3);
        }
    }
}
