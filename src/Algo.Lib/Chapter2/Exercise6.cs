using System.Collections.Generic;

namespace Algo.Lib.Chapter2
{
    public class Exercise6
    {
        public static LinkedListNode<int> FindLoop(LinkedList<int> lst)
        {
            LinkedListNode<int> slow = lst.First;
            LinkedListNode<int> fast = lst.First;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                if (slow == fast)
                {
                    break;
                }
            }

            if (fast == null || fast.Next == null)
            {
                return null;
            }

            slow = lst.First;

            while (slow != fast)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return fast;
        }
    }
}
