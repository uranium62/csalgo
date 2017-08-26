using System.Collections.Generic;

namespace Algo.Lib.Chapter3
{
    public class Exercise6
    {
        public static Stack<int> Sort(Stack<int> src)
        {
            Stack<int> des = new Stack<int>();

            while(src.Count != 0)
            {
                int tmp = src.Pop();

                while( des.Count != 0 && des.Peek() < tmp)
                {
                    src.Push(des.Pop());
                }

                des.Push(tmp);
            }

            return des;
        }
    }
}
