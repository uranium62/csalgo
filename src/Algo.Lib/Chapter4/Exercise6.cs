namespace Algo.Lib.Chapter4
{
    using System;

    public class Exercise6
    {
        public static BinaryTreeNode<int> InorderFindNext(BinaryTreeNode<int> node)
        {
            if (node == null)
            {
                return null;
            }

            // This algorith supports only one way finding
            if (node.Right != null)
            {
                return leftMostChild(node);
            }

            throw new NotImplementedException("This function doesn't support from bottom to top finding");
        }

        private static BinaryTreeNode<int> leftMostChild(BinaryTreeNode<int> node)
        {
            if (node == null)
            {
                return null;
            }

            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }
    }
}
