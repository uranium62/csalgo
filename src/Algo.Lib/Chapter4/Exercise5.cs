namespace Algo.Lib.Chapter4
{
    using System;

    public class Exercise5
    {
        public static bool IsBST(BinaryTreeNode<int> root)
        {
            return CheckBST(root, Int32.MinValue, Int32.MaxValue);
        }

        private static bool CheckBST(BinaryTreeNode<int> n, int min, int max)
        {
            if (n == null)
                return true;

            if (n.Value <= min || n.Value > max)
                return false;

            if (!CheckBST(n.Left, min, n.Value) || !CheckBST(n.Right, n.Value, max))
                return false;

            return true;
        }
    }
}
