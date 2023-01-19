using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;
using PathfindingDemo.Draw;

namespace PathfindingDemo
{
  [SuppressMessage("ReSharper", "PossibleLossOfFraction")]
  public partial class Form1 : Form
  {
    public Map FormMap { get; set; }
    public Form1()
    {
      InitializeComponent();
      Resize += Form1_Resize;
      mainWindow.Paint += Panel1_Paint;
    }


    private void Form1_Resize(object sender, EventArgs e)
    {
      mainWindow.Invalidate();
    }


    //draws the map and the shortest path
    private void Panel1_Paint(object sender, PaintEventArgs eventArgs)
    {
      if (FormMap == null) return;

      var graphics = eventArgs.Graphics;
      graphics.ScaleTransform(0.9f, 0.9f);
      graphics.TranslateTransform(20, 20);
      graphics.SmoothingMode = SmoothingMode.AntiAlias;
      graphics.CompositingQuality = CompositingQuality.HighQuality;
      graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

      var sideX = eventArgs.ClipRectangle.Width;
      var sideY = eventArgs.ClipRectangle.Height;
      const int nodeWidth = 8;

      foreach (var node in FormMap.Nodes)
      {
        var x1 = (node.Point.X * sideX);
        var y1 = (node.Point.Y * sideY);
        var x = x1 - nodeWidth / 2;
        var y = y1 - nodeWidth / 2;

        var brush = Brushes.Black;
        if (node.Visited) brush = Brushes.Red;
        if (node == FormMap.StartNode) brush = Brushes.DarkOrange;
        if (node == FormMap.EndNode) brush = Brushes.Green;
        graphics.FillEllipse(brush, (float)x, (float)y, nodeWidth, nodeWidth);

        foreach (var cnn in node.Connections)
        {
          var x2 = (cnn.ConnectedNode.Point.X * sideX);
          var y2 = (cnn.ConnectedNode.Point.Y * sideY);
          graphics.DrawLine(Pens.DarkBlue, (float)x1, (float)y1, (float)x2, (float)y2);
        }
      }

      var pen = new Pen(Brushes.YellowGreen, 2);
      for (var i = 0; i < FormMap.ShortestPath.Count - 1; i++)
      {
        var node1 = FormMap.ShortestPath[i];
        var node2 = FormMap.ShortestPath[i + 1];
        var x1 = node1.Point.X * sideX;
        var y1 = node1.Point.Y * sideY;
        var x2 = node2.Point.X * sideX;
        var y2 = node2.Point.Y * sideY;
        graphics.DrawLine(pen, (float)x1, (float)y1, (float)x2, (float)y2);
      }
    }


    private void DijikstraSearchNewMap()
    {
      console.Text = "";
      FormMap = Map.Randomize((int)numericUpDownNodeCount.Value,
                (int)numericUpDownBranching.Value,
                (int)numericUpDownSeed.Value,
                cbRandomWeights.Checked);
      var search = new Pathfinding.Pathfinding(FormMap);
      search.Updated += Search_Updated;
      var stopWatch = Stopwatch.StartNew();
      FormMap.ShortestPath = search.GetShortestPathDijikstra();
      stopWatch.Stop();
      mainWindow.Invalidate();
      PrintStats(search, stopWatch);
    }


    private void AstarSearchNewMap()
    {
      console.Text = "";
      FormMap = Map.Randomize((int)numericUpDownNodeCount.Value,
                (int)numericUpDownBranching.Value,
                (int)numericUpDownSeed.Value,
                cbRandomWeights.Checked);
      var search = new Pathfinding.Pathfinding(FormMap);
      search.Updated += Search_Updated;
      var stopWatch = Stopwatch.StartNew();
      FormMap.ShortestPath = search.GetShortestPathAstar();
      stopWatch.Stop();
      PrintStats(search, stopWatch);
      mainWindow.Invalidate();
    }


    private void PrintStats(Pathfinding.Pathfinding pathfinding, Stopwatch sw)
    {
      console.Text = $"Total: {FormMap.Nodes.Count}\r\n" +
                     $"Visited {pathfinding.NodesVisited}\r\n" +
                     $"Time: {sw.Elapsed.TotalMilliseconds}ms\r\n" +
                     $"Path length: {pathfinding.ShortestPathLength.ToString("0.00")}\r\n" +
                     $"Path Cost: {pathfinding.ShortestPathCost.ToString("0.00")}";
    }


    private void Search_Updated(object sender, EventArgs e)
    {
      mainWindow.Invalidate();
      Application.DoEvents();
      Thread.Sleep(300);
    }


    private void buttonDijkstra_Click(object sender, EventArgs e)
    {
      DijikstraSearchNewMap();
    }


    private void buttonAstar_Click(object sender, EventArgs e)
    {
      AstarSearchNewMap();
    }


    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
