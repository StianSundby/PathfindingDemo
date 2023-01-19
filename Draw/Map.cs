using System;
using System.Collections.Generic;
using System.Diagnostics;
using PathfindingDemo.Pathfinding;

namespace PathfindingDemo.Draw
{
  public class Map
  {
    public List<Node> Nodes { get; set; } = new List<Node>();
    public Node StartNode { get; set; }
    public Node EndNode { get; set; }
    public List<Node> ShortestPath { get; set; } = new List<Node>();

    public static Map Randomize(int nodeCount, int branching, int seed, bool randomWeights)
    {
      var random = new Random(seed);
      var map = new Map();

      for (var i = 0; i < nodeCount; i++)
      {
        var newNode = Node.GetRandom(random, i.ToString());
        if (!newNode.TooCloseToAny(map.Nodes)) map.Nodes.Add(newNode);
      }

      foreach (var node in map.Nodes)
      {
        node.ConnectClosestNodes(map.Nodes, branching, random, randomWeights);
      }

      map.EndNode = map.Nodes[random.Next(map.Nodes.Count - 1)];
      map.StartNode = map.Nodes[random.Next(map.Nodes.Count - 1)];

      foreach (var node in map.Nodes)
      {
        Debug.WriteLine($"{node}");
        foreach (var cnn in node.Connections)
        {
          Debug.WriteLine($"{cnn}");
        }
      }
      return map;
    }
  }
}
