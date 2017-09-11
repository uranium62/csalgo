namespace Algo.Lib.Chapter4
{
    using System.Collections.Generic;

    public enum NodeState
    {
        Unvisited,
        Visited,
        Visiting
    }

    public class GraphNode<T>
    {
        public T Value { get; set; }

        public NodeState State { get; set; }

        public List<GraphNode<T>> Nodes { get; set; }

        public GraphNode(T data) 
        {
            Value = data;
            Nodes = null;
            State = NodeState.Unvisited;
        }

        public GraphNode(T data, List<GraphNode<T>> nodes)
        {
            Value = data;
            Nodes = nodes;
            State = NodeState.Unvisited;
        }

        public GraphNode(T data, params GraphNode<T>[] nodes) : this(data, new List<GraphNode<T>>(nodes))
        {  
        }

        public void Reset()
        {
            if (State != NodeState.Unvisited)
            {
                State = NodeState.Unvisited;

                if (Nodes != null && Nodes.Count != 0)
                {
                    foreach (var node in Nodes) node.Reset();
                }
            }   
        }
    }

    public class Exercise2
    {
        public static bool DepthSearch(GraphNode<int> graph, GraphNode<int> start, GraphNode<int> end)
        {
            graph.Reset();

            var stack = new Stack<GraphNode<int>>();

            start.State = NodeState.Visiting;
            stack.Push(start);

            while (stack.Count != 0)
            {
                GraphNode<int> current = stack.Pop();

                if (current != null && current.Nodes != null)
                {
                    foreach (var node in current.Nodes)
                    {
                        if (node.State == NodeState.Unvisited)
                        {
                            if (node == end)
                                return true;

                            node.State = NodeState.Visiting;
                            stack.Push(node);
                        }
                    }
                }
            }

            return false;
        }

        public static bool WidthSearch(GraphNode<int> graph, GraphNode<int> start, GraphNode<int> end)
        {
            graph.Reset();

            var queue = new Queue<GraphNode<int>>();

            start.State = NodeState.Visiting;
            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                GraphNode<int> current = queue.Dequeue();

                if (current != null && current.Nodes != null)
                {
                    foreach (var node in current.Nodes)
                    {
                        if (node.State == NodeState.Unvisited)
                        {
                            if (node == end)
                                return true;

                            node.State = NodeState.Visiting;
                            queue.Enqueue(node);
                        }
                    }
                    current.State = NodeState.Visited;
                }
            }

            return false;
        }
    }
}
