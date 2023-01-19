using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using PathfindingDemo.Draw;

namespace PathfindingDemo.Pathfinding
{
  public class Pathfinding
  {
    public event EventHandler Updated;
    private void OnUpdated()
    {
      Updated?.Invoke(null, EventArgs.Empty);
    }
    public Map Map { get; set; }
    public Node Start { get; set; }
    public Node End { get; set; }
    public int NodesVisited { get; private set; }
    public double ShortestPathLength { get; set; }
    public double ShortestPathCost { get; private set; }

    public Pathfinding(Map map)
    {
      Map = map;
      End = map.EndNode;
      Start = map.StartNode;
    }


    private void BuildShortestPath(ICollection<Node> list, Node node)
    {
      if (node.ClosestToStart == null) return;
      list.Add(node.ClosestToStart);
      ShortestPathLength += node.Connections.Single(x => x.ConnectedNode == node.ClosestToStart).Length;
      ShortestPathCost += node.Connections.Single(x => x.ConnectedNode == node.ClosestToStart).Cost;
      BuildShortestPath(list, node.ClosestToStart);
    }


    #region Dijkstra's Shortest Path

    public List<Node> GetShortestPathDijikstra()
    {
      DijkstraSearch();
      var shortestPath = new List<Node> { End };
      BuildShortestPath(shortestPath, End);
      shortestPath.Reverse();
      return shortestPath;
    }


    private void DijkstraSearch()
    {
      NodesVisited = 0;
      Start.MinCostToStart = 0;
      var prioQueue = new List<Node> { Start };
      do
      {
        NodesVisited++;
        prioQueue = prioQueue.OrderBy(x =>
        {
          Debug.Assert(x.MinCostToStart != null, "x.MinCostToStart != null");
          return x.MinCostToStart.Value;
        }).ToList();
        var node = prioQueue.First();
        prioQueue.Remove(node);
        foreach (var connection in node.Connections.OrderBy(x => x.Cost))
        {
          var childNode = connection.ConnectedNode;
          if (childNode.Visited)
            continue;
          if (childNode.MinCostToStart != null &&
              !(node.MinCostToStart + connection.Cost <
                childNode.MinCostToStart)) continue;
          childNode.MinCostToStart = node.MinCostToStart + connection.Cost;
          childNode.ClosestToStart = node;
          if (!prioQueue.Contains(childNode)) prioQueue.Add(childNode);
        }
        node.Visited = true;
        if (node == End) return;
      } while (prioQueue.Any());
    }
    #endregion


    #region A* Shortest Path
    public List<Node> GetShortestPathAstar()
    {
      foreach (var node in Map.Nodes)
      {
        node.StraightLineDistanceToEnd = node.StraightLineDistanceTo(End);
      }
      AstarSearch();
      var shortestPath = new List<Node> { End };
      BuildShortestPath(shortestPath, End);
      shortestPath.Reverse();
      return shortestPath;
    }


    private void AstarSearch()
    {
      NodesVisited = 0;
      Start.MinCostToStart = 0;
      var prioQueue = new List<Node> { Start };
      do
      {
        prioQueue = prioQueue.OrderBy(x => x.MinCostToStart + x.StraightLineDistanceToEnd).ToList();
        var node = prioQueue.First();
        prioQueue.Remove(node);
        NodesVisited++;
        foreach (var connection in node.Connections.OrderBy(x => x.Cost))
        {
          var childNode = connection.ConnectedNode;
          if (childNode.Visited) continue;
          if (childNode.MinCostToStart != null &&
              !(node.MinCostToStart + connection.Cost <
                childNode.MinCostToStart)) continue;
          childNode.MinCostToStart = node.MinCostToStart + connection.Cost;
          childNode.ClosestToStart = node;
          if (!prioQueue.Contains(childNode)) prioQueue.Add(childNode);
        }
        node.Visited = true;
        if (node == End) return;
      } while (prioQueue.Any());
    }
    #endregion
  }
}
