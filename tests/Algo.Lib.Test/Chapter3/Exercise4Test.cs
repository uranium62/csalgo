using Algo.Lib.Chapter3;
using Xunit;

namespace Algo.Lib.Test.Chapter3
{
    public class Exercise4Test
    {
        [Fact]
        public void Move_towers()
        {
            int n = 3;
            Tower[] towers = new Tower[n];
            for(int i = 0; i < n; i++)
            {
                towers[i] = new Tower(i);
            }
            for(int i = n-1; i >=0 ; i--)
            {
                towers[0].Add(i);
            }

            Exercise4.MoveDiscks(towers, n);

            Assert.Equal(towers[2].Disks.Pop(), 0);
            Assert.Equal(towers[2].Disks.Pop(), 1);
            Assert.Equal(towers[2].Disks.Pop(), 2);
        }
    }
}
