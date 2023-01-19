using System;
using System.Collections.Generic;
using System.Linq;
using PathfindingDemo.Draw;

namespace PathfindingDemo.Pathfinding
{
  public class Node
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Point Point { get; set; }
    public List<Edge> Connections { get; set; } = new List<Edge>();

    public double? MinCostToStart { get; set; }
    public Node ClosestToStart { get; set; }
    public bool Visited { get; set; }
    public double StraightLineDistanceToEnd { get; set; }


    internal static Node GetRandom(Random random, string name)
    {
      return new Node
      {
        Point = new Point
        {
          X = random.NextDouble(),
          Y = random.NextDouble()
        },
        Id = Guid.NewGuid(),
        Name = name
      };
    }


    internal void ConnectClosestNodes(List<Node> nodes, int branching, Random random, bool randomWeight)
    {
      var connections = new List<Edge>();
      foreach (var node in nodes)
      {
        if (node.Id == Id) continue;

        var distance = Math.Sqrt(Math.Pow(Point.X - node.Point.X, 2) + Math.Pow(Point.Y - node.Point.Y, 2));

        connections.Add(new Edge
        {
          ConnectedNode = node,
          Length = distance,
          Cost = randomWeight ? random.NextDouble() : distance,
        });
      }

      connections = connections.OrderBy(x => x.Length).ToList();
      var count = 0;
      foreach (var connection in connections)
      {
        //Connect the three closest nodes that are not connected
        if (Connections.All(c => c.ConnectedNode != connection.ConnectedNode))
          Connections.Add(connection);
        count++;

        //Make it a two way connection if not already connected
        if (connection.ConnectedNode.Connections.All(cc => cc.ConnectedNode != this))
        {
          var backConnection = new Edge { ConnectedNode = this, Length = connection.Length };
          connection.ConnectedNode.Connections.Add(backConnection);
        }

        if (count == branching) return;
      }
    }


    public double StraightLineDistanceTo(Node end)
    {
      return Math.Sqrt(Math.Pow(Point.X - end.Point.X, 2) + Math.Pow(Point.Y - end.Point.Y, 2));
    }


    internal bool TooCloseToAny(List<Node> nodes)
    {
      foreach (var node in nodes)
      {
        var distance = Math.Sqrt(Math.Pow(Point.X - node.Point.X, 2) + Math.Pow(Point.Y - node.Point.Y, 2));
        if (distance < 0.01) return true;
      }
      return false;
    }


    public override string ToString()
    {
      return Name;
    }
  }
}
