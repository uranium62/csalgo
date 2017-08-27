using System.Collections.Generic;

namespace Algo.Lib.Chapter3
{
    public class StackMin : Stack<int>
    {
        public Stack<int> _mins;

        public StackMin()
        {
            _mins = new Stack<int>();
        }

        public void PushVal(int value)
        {
            if (value <= Min())
            {
                _mins.Push(value);
            }
            base.Push(value);
        }

        public int PopVal()
        {
            var value = base.Pop();

            if (value == Min())
            {
                _mins.Pop();
            }

            return value;
        }

        public int Min()
        {
            if (_mins.Count == 0)
            {
                return int.MaxValue;
            }

            return _mins.Peek();
        }
    }

    public class Exercise2
    {
        public static int Min(StackMin stack)
        {
            return stack.Min();
        }
    }
}
