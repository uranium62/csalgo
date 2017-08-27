namespace Algo.Lib.Chapter4
{
    using System.Collections.ObjectModel;

    public class Node<T>
    {
        public Node() { }
        public Node(T data) : this(data, null) { }

        public Node(T data, NodeList<T> neighbors)
        {
            Value = data;
            Neighbors = neighbors;
        }

        public T Value { get; set; }

        protected NodeList<T> Neighbors { get; set; }
    }

    public class NodeList<T> : Collection<Node<T>>
    {
        public NodeList() { }

        public NodeList(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Items.Add(default(Node<T>));
            }
        }

        public Node<T> FindByValue(T value)
        {
            foreach (var node in Items)
            {
                if (node.Value.Equals(value))
                    return node;
            }
            return null;
        }

    }

    public class BinaryTreeNode<T> : Node<T>
    {
        public BinaryTreeNode() {}
        public BinaryTreeNode(T data) : base(data, null) {}

        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            Value = data;
            NodeList<T> children = new NodeList<T>(2);
            children[0] = left;
            children[1] = right;
            Neighbors = children;
        }

        public BinaryTreeNode<T> Left
        {
            get
            {
                if (Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>) Neighbors[0];
            }
            set
            {
                if (Neighbors == null)
                    Neighbors = new NodeList<T>(2);
                
                Neighbors[0] = value;
            }
        }
        
        public BinaryTreeNode<T> Right
        {
            get
            {
                if (Neighbors == null)
                    return null;
                else
                    return (BinaryTreeNode<T>) Neighbors[1];
            }
            set
            {
                if (Neighbors == null)
                    Neighbors = new NodeList<T>(2);
                
                Neighbors[1] = value;
            }
        }
    }
    
    public class BinaryTree<T>
    {
        public BinaryTree()
        {
            Root = null;
        }

        public virtual void Clear()
        {
            Root = null;
        }

        public BinaryTreeNode<T> Root { get; set; }
    }

    public class Exercise1
    {
    }
}
