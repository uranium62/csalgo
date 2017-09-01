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

        public GraphNode(T data) : this(data, null)
        {
        }

        public GraphNode(T data, List<GraphNode<T>> nodes)
        {
            Value = data;
            Nodes = nodes;
            State = NodeState.Unvisited;
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
        public static void DepthSearch(GraphNode<int> graph, GraphNode<int> start, GraphNode<int> end)
        {
            graph.Reset();

            var stack = new Stack<GraphNode<int>>();
        }

        public static void WidthSearch(GraphNode<int> graph, GraphNode<int> start, GraphNode<int> end)
        {
            graph.Reset();
        }
    }
}
