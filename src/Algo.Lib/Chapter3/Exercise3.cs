using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.Lib.Chapter3
{
    public class SetOfStacks
    {
        private readonly int _cap;
        private Stack<Stack<int>> _stacks;

        public SetOfStacks(int splitCapacity)
        {
            _cap = splitCapacity;
            _stacks = new Stack<Stack<int>>();
        }

        public void Push(int value)
        {
            Stack<int> stack = GetLastStack();

            if (stack == null || stack.Count == _cap)
            {
                stack = new Stack<int>();
                stack.Push(value);
                _stacks.Push(stack);
            }
            else
            {
                stack.Push(value);
            }
        }

        public int Pop()
        {
            Stack<int> stack = GetLastStack();

            if (stack == null)
            {
                throw new Exception("The setOfStack is empty");
            }

            var value = stack.Pop();

            if (stack.Count == 0)
            {
                _stacks.Pop();
            }

            return value;
        }

        private Stack<int> GetLastStack()
        {
            if (_stacks.Count == 0)
            {
                return null;
            }
            return _stacks.Peek();
        }

        public int Count => _stacks.Count;
    }

    public class Exercise3
    {
        public static void Push(SetOfStacks set, int value)
        {
            set.Push(value);
        }

        public static int Pop(SetOfStacks set)
        {
            return set.Pop();
        }
    }
}
