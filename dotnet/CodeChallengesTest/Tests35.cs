using DataStructures.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengesTest
{
    public class Tests35
    {



        //Node can be successfully added to the graph
        [Fact]
        public void Graph1()
        {
            //Setting up test graph
            Graph<string> test = new();
            //adding a node
            Vertex<string> node1 = test.AddNode("1");

            //Setting up results
            List<Vertex<String>> expectedNodes = new();
            expectedNodes.Add(node1);

            Assert.Equal(1, test.GetSize());
            Assert.Equal(expectedNodes, test.GetNodes());
        }

        //An edge can be successfully added to the graph
        [Fact]
        public void Graph2()
        {
            //Setting up test graph
            Graph<string> test = new();
            //adding a node
            var node1 = test.AddNode("1");
            var node2 = test.AddNode("2");
            //adding an edge
            test.AddEdge(node1, node2, 2);

            //Setting up results
            List<Vertex<String>> expectedNodes = new();
            expectedNodes.Add(node2);

            List<Vertex<String>> neighbors = test.GetNeighbors(node1);

            Assert.Equal(expectedNodes, neighbors);
        }

        //A collection of all nodes can be properly retrieved from the graph
        [Fact]
        public void Graph3()
        {
            //Setting up test graph
            Graph<string> test = new();
            //adding a node
            var node1 = test.AddNode("1");
            var node2 = test.AddNode("2");
            var node3 = test.AddNode("3");
            //adding an edge
            test.AddEdge(node1, node2, 2);

            //Setting up results
            List<Vertex<String>> expectedNodes = new();
            expectedNodes.Add(node1);
            expectedNodes.Add(node2);
            expectedNodes.Add(node3);


            Assert.Equal(expectedNodes, test.GetNodes());
        }


        //All appropriate neighbors can be retrieved from the graph
        [Fact]
        public void Graph4()
        {
            //Setting up test graph
            Graph<string> test = new();
            //adding a node
            var node1 = test.AddNode("1");
            var node2 = test.AddNode("2");
            var node3 = test.AddNode("3");
            var node4 = test.AddNode("4");
            //adding an edge
            test.AddEdge(node1, node2, 2);
            test.AddEdge(node1, node3, 2);
            test.AddEdge(node3, node4, 2);

            //Setting up results
            List<Vertex<String>> expectedNodes = new();
            expectedNodes.Add(node2);
            expectedNodes.Add(node3);


            Assert.Equal(expectedNodes, test.GetNeighbors(node1));
        }

        //Neighbors are returned with the weight between nodes included
        [Fact]
        public void Graph5()
        {
            //The way Ed showed us did not include this so... yeah. Taking a hit here sorry
        }

        //The proper size is returned, representing the number of nodes in the graph
        [Fact]
        public void Graph6()
        {
            //Setting up test graph
            Graph<string> test = new();
            //adding a node
            var node1 = test.AddNode("1");
            var node2 = test.AddNode("2");
            var node3 = test.AddNode("3");
            var node4 = test.AddNode("4");



            Assert.Equal(4, test.GetSize());
        }

        //A graph with only one node and edge can be properly returned
        [Fact]
        public void Graph7()
        {
            //I don't get this, an edge requires 2 nodes already in the graph so this cant be done
        }

        //An empty graph properly returns null
        [Fact]
        public void Graph8()
        {
            //Setting up test graph
            Graph<string> test = new();

            Assert.Null(test.GetNodes());
        }


    }

}
