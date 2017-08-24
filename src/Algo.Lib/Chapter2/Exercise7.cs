using System.Collections.Generic;

namespace Algo.Lib.Chapter2
{
    public class Exercise7
    {
        public static bool IsPolindrome(LinkedList<int> lst)
        {
            LinkedListNode<int> head = lst.First;
            LinkedListNode<int> tail = lst.Last;

            while(head != tail)
            {
                if (head.Value != tail.Value)
                {
                    return false;
                }

                head = head.Next;
                tail = tail.Previous;
            }
            return true;
        }
    }
}
