namespace Algo.Lib.Chapter4
{
    public class Exercise7
    {
        public static BinaryTreeNode<int> FindParent(BinaryTreeNode<int> root, BinaryTreeNode<int> n1, BinaryTreeNode<int> n2)
        {
            return Postorder(root, n1, n2).Item2;
        }

        private static (bool, BinaryTreeNode<int>) Postorder(BinaryTreeNode<int> node, BinaryTreeNode<int> n1, BinaryTreeNode<int> n2)
        {
            if (node == null)
            {
                return (false, null);
            }

            if (node.Value == n1.Value || node.Value == n2.Value)
            {
                return (true, null);
            }

            var left = Postorder(node.Left, n1, n2);

            if (left.Item2 != null)
            {
                return left;
            }

            var right = Postorder(node.Right, n1, n2);

            if (right.Item2 != null)
            {
                return right;
            }

            if (left.Item1 && right.Item1)
            {
                return (true, node);
            }

            if (left.Item1 || right.Item1)
            {
                return (true, null);
            }

            return (false, null);
        }
    }
}
