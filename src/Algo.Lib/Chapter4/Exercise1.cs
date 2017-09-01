namespace Algo.Lib.Chapter4
{
    using System;

    public class BinaryTreeNode<T> 
    {   
        public BinaryTreeNode(T data) : this(data, null, null) {}

        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            Value = data;
            Left = left;
            Right = right;
        }

        public T Value { get; set; }

        public BinaryTreeNode<T> Left { get; set; }
 
        public BinaryTreeNode<T> Right { get; set; }

    }
    public class Exercise1
    {
        public static bool IsBalance(BinaryTreeNode<int> root)
        {
            return Height(root) != -1;
        }

        private static int Height(BinaryTreeNode<int> root)
        {
            if (root == null)
                return 0;

            int leftHeight = Height(root.Left);
            if (leftHeight == -1)
                return -1;

            int rightHeight = Height(root.Right);
            if (rightHeight == -1)
                return -1;

            int diffHeight = Math.Abs(leftHeight - rightHeight);
            if (diffHeight > 1)
                return -1;

            return Math.Max(rightHeight, leftHeight) + 1;
        }
    }
}
