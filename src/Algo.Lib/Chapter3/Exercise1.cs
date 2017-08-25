using System;
using System.Collections.Generic;
using System.Text;

namespace Algo.Lib.Chapter3
{
    public class StackArray
    {
        private readonly int _size;
        private readonly int[] _buffer;
        private readonly int[] _pointer;

        public StackArray(int size)
        {
            _size = size;
            _buffer = new int[_size * 3];
            _pointer = new int[] { 0, 0, 0 };

        }


        public void Push(int stackNum, int value)
        {
            if (_pointer[stackNum] >= _size)
            {
                throw new Exception("The stack doesn't have enought space");
            }
            int idx = stackNum * _size + _pointer[stackNum] + 1;
            _pointer[stackNum]++;
            _buffer[idx] = value;
        }

        public int Pop(int stackNum)
        {
            if (_pointer[stackNum] == 0)
            {
                throw new Exception("The stack is empty");
            }
            int idx = stackNum * _size + _pointer[stackNum];
            _pointer[stackNum]--;
            return _buffer[idx];
        }

        public int Peek(int stackNum)
        {
            int idx = stackNum * _size + _pointer[stackNum];
            return _buffer[idx];
        }

    }

    public class Exercise1
    {
        public static void Push(StackArray stack, int stackNum, int value)
        {
            stack.Push(stackNum, value);
        }

        public static int Pop(StackArray stack, int stackNum)
        {
            return stack.Pop(stackNum);
        }

        public static int Peek(StackArray stack, int stackNum)
        {
            return stack.Peek(stackNum);
        }
    }
}
