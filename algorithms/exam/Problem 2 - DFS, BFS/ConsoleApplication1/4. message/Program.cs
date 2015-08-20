using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.message
{
    class Program
    {
        //topological sort
        static SortedDictionary<char, Node> graph = new SortedDictionary<char, Node>();
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            var noIncomming = new SortedSet<char>();
            for (int i = 0; i < n; i++)
            {
                string currentMessage = Console.ReadLine();
                Node previousNode = GetNodeByChar(currentMessage[0]);

                for (int j = 1; j < currentMessage.Length; j++)
                {
                    
                    Node currentNode = GetNodeByChar(currentMessage[j]);

                    previousNode.Successors.Add(currentNode);
                    currentNode.Parents.Add(previousNode);

                    previousNode = currentNode;
                }
            }

            foreach (var node in graph.Values)
            {
                if (node.Parents.Count == 0)
                {
                    noIncomming.Add(node.Value);
                }
            }

            var result = new List<char>();

            while (noIncomming.Count > 0)
            {
                var currentNodeSynbol = noIncomming.Min;
                noIncomming.Remove(currentNodeSynbol);

                result.Add(currentNodeSynbol);

                var currentNode = graph[currentNodeSynbol];
                var children = graph[currentNodeSynbol].Successors.ToList();
                foreach (var child in children)
                {
                    child.Parents.Remove(currentNode);
                    currentNode.Successors.Remove(child);
                    if (child.Parents.Count == 0)
                    {
                        noIncomming.Add(child.Value);
                    }
                }
            }

            Console.WriteLine(string.Join("", result));
        }

        static Node GetNodeByChar(char symbol)
        {
            if (graph.ContainsKey(symbol))
            {
                return graph[symbol];
            }

            var newNode = new Node
            {
                Value = symbol
            };

            graph.Add(symbol, newNode);

            return newNode;
        }

        class Node
        {
            public Node()
            {
                this.Parents = new HashSet<Node>();
                this.Successors = new HashSet<Node>();
            }
            public char Value { get; set; }

            public ICollection<Node> Successors { get; set; }

            public ICollection<Node> Parents { get; set; }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }
        }
    }
}
