namespace Algo.Lib.Chapter2
{
    using System.Collections.Generic;

    public class Exercise3
    {
        public static bool DeleteNode(LinkedList<int> lst, LinkedListNode<int> node)
        {
            // If node.Next was editable 
            // I would copy the next element into current

            lst.Remove(node);
            return true;
        } 
    }
}
