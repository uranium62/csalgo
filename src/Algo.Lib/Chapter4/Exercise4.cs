namespace Algo.Lib.Chapter4
{
    using System.Collections.Generic;

    public class Exercise4
    {
        public static List<LinkedList<BinaryTreeNode<int>>> CreateLevelLinkedList(BinaryTreeNode<int> root)
        {
            List<LinkedList<BinaryTreeNode<int>>> result = new List<LinkedList<BinaryTreeNode<int>>>();

            LinkedList<BinaryTreeNode<int>> current = new LinkedList<BinaryTreeNode<int>>();
            if (root != null)
            {
                current.AddFirst(root);
            }
                
            while (current.Count > 0)
            {
                result.Add(current);
                LinkedList<BinaryTreeNode<int>> parents = current;
                current = new LinkedList<BinaryTreeNode<int>>();
                foreach (BinaryTreeNode<int> parent in parents)
                {
                    if (parent.Left != null)
                    {
                        current.AddFirst(parent.Left);
                    }
                    if (parent.Right != null)
                    {
                        current.AddFirst(parent.Right);
                    }
                }
            }

            return result;
        }
    }
}
