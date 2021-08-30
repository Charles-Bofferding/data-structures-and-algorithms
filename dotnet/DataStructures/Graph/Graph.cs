using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{

    public class Vertex<T>
    {
        public T Value { get; set; }

        public Vertex(T value)
        {
            Value = value;
        }
    }

    //This will live in a vertex so it only needs a destination and not an origin
    public class Edge<T> 
    {
        public int Weight { get; set; }
        public Vertex<T> Vertex { get; set; }

        public Edge(Vertex<T> vertex, int weight)
        {
            Vertex = vertex;
            Weight = weight;
        }
    }

    public class Graph<T>
    {

        public Graph()
        {
            AdjacenyLists = new Dictionary<Vertex<T>, List<Edge<T>>>();
            _size = 0;
            Nodes = new List<Vertex<T>>();
        }

        public Dictionary<Vertex<T>, List<Edge<T>>> AdjacenyLists {get; set;}

        public List<Vertex<T>> Nodes { get; set; }

        private int _size;

        public Vertex<T> AddNode(T value)
        {
            Vertex<T> Vertex = new(value);
            Nodes.Add(Vertex);
            AdjacenyLists.Add(Vertex, new List<Edge<T>>());
            _size++;
            return Vertex;
        }

        //I know this contaqins repeated code and should have a helper method but ... meh
        public void AddEdge(Vertex<T> vertexA, Vertex<T> vertexB, int weight)
        {
            List<Edge<T>> currentEdgesA = AdjacenyLists[vertexA];
            Edge<T> newEdgeA = new(vertexB, weight);
            currentEdgesA.Add(newEdgeA);

            List<Edge<T>> currentEdgesB = AdjacenyLists[vertexB];
            Edge<T> newEdgeB = new(vertexA, weight);
            currentEdgesB.Add(newEdgeB);
        }

        public List<Vertex<T>> GetNodes()
        {
            if(_size > 0)
            {
                return Nodes;
            }

            return null;

        }

        public List<Vertex<T>> GetNeighbors(Vertex<T> current)
        {

            List<Edge<T>> adjacencyList = AdjacenyLists[current];
            List<Vertex<T>> output = new();
            foreach (Edge<T> edge in adjacencyList)
            {
                output.Add(edge.Vertex);
            }
            return output;
        }

        public int GetSize()
        {
            return _size;
        }

        public void Print()
        {
            foreach (var entry in AdjacenyLists)
            {
                Console.Write($"{entry.Key.Value} -> ");
                var connections = AdjacenyLists[entry.Key];
                foreach (Edge<T> edge in connections)
                {
                    Console.Write($"{edge.Vertex.Value} -> ");
                };
                Console.WriteLine("Null");
            }
        }
    }
}