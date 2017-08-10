using System.Collections.Generic;

namespace Algo.Lib.Chapter2
{
    public class Exercise2
    {
        public static LinkedListNode<int> FindNodeFromEnd(LinkedList<int> lst, int k)
        {
            LinkedListNode<int> cur = lst.First;
            LinkedListNode<int> elm = lst.First;

            for (int i = 0; i < k - 1; i++)
            {
                if (cur == null) return null;
                cur = cur.Next;
            }

            if (cur == null) return null;

            while (cur.Next != null)
            {
                cur = cur.Next;
                elm = elm.Next;
            }

            return elm;
        }
    }
}
