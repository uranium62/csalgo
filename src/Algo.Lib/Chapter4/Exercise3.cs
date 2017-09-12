namespace Algo.Lib.Chapter4
{
    public class Exercise3
    {
        public static BinaryTreeNode<int> CreateBST(int[] arr)
        {
            return CreateBST(arr, 0, arr.Length - 1);
        }

        private static BinaryTreeNode<int> CreateBST(int[] arr, int start, int end)
        {
            if (end < start)
                return null;

            int mid = (start + end) / 2;

            BinaryTreeNode<int> node = new BinaryTreeNode<int>(arr[mid]);
            node.Left = CreateBST(arr, start, mid - 1);
            node.Right = CreateBST(arr, mid + 1, end);

            return node;
        }
    }
}
