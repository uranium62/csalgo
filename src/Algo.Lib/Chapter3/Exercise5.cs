using System.Collections.Generic;

namespace Algo.Lib.Chapter3
{
    public class StackQueue
    {
        private readonly Stack<int> _left;
        private readonly Stack<int> _right;

        public StackQueue()
        {
            _left = new Stack<int>();
            _right = new Stack<int>();
        }

        public void Push(int value)
        {
            _left.Push(value);
        }

        public int Pop()
        {
            if (_right.Count == 0)
            {
                foreach(int val in _left)
                {
                    _right.Push(val);
                }
            }
            return _right.Pop();
        }
    }

    class Exercise5
    {
        public static void Push(StackQueue queue, int val)
        {
            queue.Push(val);
        }

        public static int Pop(StackQueue queue)
        {
            return queue.Pop();
        }
    }
}
