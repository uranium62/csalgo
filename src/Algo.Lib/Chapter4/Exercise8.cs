namespace Algo.Lib.Chapter4
{
    public class Exercise8
    {
        public static bool Contains(BinaryTreeNode<int> t1, BinaryTreeNode<int> t2)
        {
            if (t1 == null)
            {
                return true;
            }
            if (t1.Value == t2.Value)
            {
                if (IsMatchTree(t1, t2)) return true;
            }
            return Contains(t1.Left, t2) || Contains(t1.Right, t2);
        }

        private static bool IsMatchTree(BinaryTreeNode<int> t1, BinaryTreeNode<int> t2)
        {
            if (t1 == null && t2 == null)
            {
                return true;
            }

            if (t1 == null || t2 == null)
            {
                return false;
            }

            if (t1.Value != t2.Value)
            {
                return false;
            }

            return IsMatchTree(t1.Left, t2.Left) && IsMatchTree(t1.Right, t2.Right);
        }
    }
}
