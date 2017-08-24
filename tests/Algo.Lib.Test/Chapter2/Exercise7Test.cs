using Algo.Lib.Chapter2;
using System.Collections.Generic;
using Xunit;

namespace Algo.Lib.Test.Chapter2
{
    public class Exercise7Test
    {
        [Fact]
        public void Check_polindrome_odd()
        {
            LinkedList<int> lst = new LinkedList<int>();
            lst.AddLast(1);
            lst.AddLast(2);
            lst.AddLast(2);
            lst.AddLast(1);

            var isPolindrome = Exercise7.IsPolindrome(lst);

            Assert.True(isPolindrome);
        }

        [Fact]
        public void Check_polindrome()
        {
            LinkedList<int> lst = new LinkedList<int>();
            lst.AddLast(1);
            lst.AddLast(2);
            lst.AddLast(3);
            lst.AddLast(2);
            lst.AddLast(1);

            var isPolindrome = Exercise7.IsPolindrome(lst);

            Assert.True(isPolindrome);
        }

        [Fact]
        public void Check_unpolindrome()
        {
            LinkedList<int> lst = new LinkedList<int>();
            lst.AddLast(1);
            lst.AddLast(2);
            lst.AddLast(3);
            lst.AddLast(3);
            lst.AddLast(1);

            var isPolindrome = Exercise7.IsPolindrome(lst);

            Assert.False(isPolindrome);
        }
    }
}
