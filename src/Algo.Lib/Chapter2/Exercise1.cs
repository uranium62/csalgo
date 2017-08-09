namespace Algo.Lib.Chapter2
{
    using System.Collections.Generic;

    public class Exercise1
    {
        public static LinkedList<int> RemoveDups(LinkedList<int> lst)
        {
            LinkedList<int> res = new LinkedList<int>();
            HashSet<int> checker = new HashSet<int>();

            LinkedListNode<int> curr = lst.First;

            while (curr != null)
            {
                if (!checker.Contains(curr.Value))
                {
                    res.AddLast(curr.Value);
                    checker.Add(curr.Value);
                }
                curr = curr.Next;
            }

            return res;
        }
    }
}
