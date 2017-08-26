using System;
using System.Collections.Generic;

namespace Algo.Lib.Chapter3
{
    public class Tower
    {
        private Stack<int> _disks;

        private int _index;

        public Tower(int i)
        {
            _disks = new Stack<int>();
            _index = i;
        }

        public int Index => _index;

        public void Add(int d)
        {
            if (_disks.Count != 0 && _disks.Peek() <= d)
                throw new Exception("Error moving the disk");
            else
                _disks.Push(d);
        }

        public void MoveTopTo(Tower t)
        {
            int top = _disks.Pop();
            t.Add(top);
        }

        public void MoveDiscks(int n, Tower des, Tower buf)
        {
            if (n > 0)
            {
                MoveDiscks(n - 1, buf, des);
                MoveTopTo(des);
                buf.MoveDiscks(n - 1, des, this);
            }
        }

        public Stack<int> Disks => _disks;
    }

    public class Exercise4
    {
        public static void MoveDiscks(Tower[] towers, int n = 3)
        {
            towers[0].MoveDiscks(n, towers[2], towers[1]);
        }
    }
}
