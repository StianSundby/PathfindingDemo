
namespace PathfindingDemo
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.console = new System.Windows.Forms.RichTextBox();
      this.mainWindow = new System.Windows.Forms.Panel();
      this.nodesText = new System.Windows.Forms.Label();
      this.numericUpDownNodeCount = new System.Windows.Forms.NumericUpDown();
      this.branchingText = new System.Windows.Forms.Label();
      this.numericUpDownBranching = new System.Windows.Forms.NumericUpDown();
      this.seedText = new System.Windows.Forms.Label();
      this.numericUpDownSeed = new System.Windows.Forms.NumericUpDown();
      this.cbRandomWeights = new System.Windows.Forms.CheckBox();
      this.buttonDijkstra = new System.Windows.Forms.Button();
      this.buttonAstar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNodeCount)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBranching)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeed)).BeginInit();
      this.SuspendLayout();
      // 
      // console
      // 
      this.console.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.console.Location = new System.Drawing.Point(0, 691);
      this.console.Margin = new System.Windows.Forms.Padding(2);
      this.console.Name = "console";
      this.console.Size = new System.Drawing.Size(927, 152);
      this.console.TabIndex = 0;
      this.console.Text = "";
      // 
      // mainWindow
      // 
      this.mainWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainWindow.Location = new System.Drawing.Point(4, 24);
      this.mainWindow.Margin = new System.Windows.Forms.Padding(2);
      this.mainWindow.Name = "mainWindow";
      this.mainWindow.Size = new System.Drawing.Size(923, 662);
      this.mainWindow.TabIndex = 9;
      // 
      // nodesText
      // 
      this.nodesText.AutoSize = true;
      this.nodesText.Location = new System.Drawing.Point(2, 3);
      this.nodesText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.nodesText.Name = "nodesText";
      this.nodesText.Size = new System.Drawing.Size(41, 13);
      this.nodesText.TabIndex = 0;
      this.nodesText.Text = "Nodes:";
      // 
      // numericUpDownNodeCount
      // 
      this.numericUpDownNodeCount.Location = new System.Drawing.Point(46, 2);
      this.numericUpDownNodeCount.Margin = new System.Windows.Forms.Padding(2);
      this.numericUpDownNodeCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numericUpDownNodeCount.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numericUpDownNodeCount.Name = "numericUpDownNodeCount";
      this.numericUpDownNodeCount.Size = new System.Drawing.Size(46, 20);
      this.numericUpDownNodeCount.TabIndex = 1;
      this.numericUpDownNodeCount.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
      // 
      // branchingText
      // 
      this.branchingText.AutoSize = true;
      this.branchingText.Location = new System.Drawing.Point(114, 3);
      this.branchingText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.branchingText.Name = "branchingText";
      this.branchingText.Size = new System.Drawing.Size(58, 13);
      this.branchingText.TabIndex = 2;
      this.branchingText.Text = "Branching:";
      // 
      // numericUpDownBranching
      // 
      this.numericUpDownBranching.Location = new System.Drawing.Point(172, 2);
      this.numericUpDownBranching.Margin = new System.Windows.Forms.Padding(2);
      this.numericUpDownBranching.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numericUpDownBranching.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.numericUpDownBranching.Name = "numericUpDownBranching";
      this.numericUpDownBranching.Size = new System.Drawing.Size(51, 20);
      this.numericUpDownBranching.TabIndex = 3;
      this.numericUpDownBranching.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
      // 
      // seedText
      // 
      this.seedText.AutoSize = true;
      this.seedText.Location = new System.Drawing.Point(255, 3);
      this.seedText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.seedText.Name = "seedText";
      this.seedText.Size = new System.Drawing.Size(35, 13);
      this.seedText.TabIndex = 4;
      this.seedText.Text = "Seed:";
      // 
      // numericUpDownSeed
      // 
      this.numericUpDownSeed.Location = new System.Drawing.Point(293, 2);
      this.numericUpDownSeed.Margin = new System.Windows.Forms.Padding(2);
      this.numericUpDownSeed.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numericUpDownSeed.Name = "numericUpDownSeed";
      this.numericUpDownSeed.Size = new System.Drawing.Size(53, 20);
      this.numericUpDownSeed.TabIndex = 5;
      this.numericUpDownSeed.Value = new decimal(new int[] {
            773,
            0,
            0,
            0});
      // 
      // cbRandomWeights
      // 
      this.cbRandomWeights.AutoSize = true;
      this.cbRandomWeights.Location = new System.Drawing.Point(372, 3);
      this.cbRandomWeights.Name = "cbRandomWeights";
      this.cbRandomWeights.Size = new System.Drawing.Size(95, 17);
      this.cbRandomWeights.TabIndex = 12;
      this.cbRandomWeights.Text = "Random Costs";
      this.cbRandomWeights.UseVisualStyleBackColor = true;
      // 
      // buttonDijkstra
      // 
      this.buttonDijkstra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDijkstra.Location = new System.Drawing.Point(719, 3);
      this.buttonDijkstra.Margin = new System.Windows.Forms.Padding(2);
      this.buttonDijkstra.Name = "buttonDijkstra";
      this.buttonDijkstra.Size = new System.Drawing.Size(56, 19);
      this.buttonDijkstra.TabIndex = 6;
      this.buttonDijkstra.Text = "Dijkstra";
      this.buttonDijkstra.UseVisualStyleBackColor = true;
      this.buttonDijkstra.Click += new System.EventHandler(this.buttonDijkstra_Click);
      // 
      // buttonAstar
      // 
      this.buttonAstar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonAstar.Location = new System.Drawing.Point(779, 3);
      this.buttonAstar.Margin = new System.Windows.Forms.Padding(2);
      this.buttonAstar.Name = "buttonAstar";
      this.buttonAstar.Size = new System.Drawing.Size(56, 19);
      this.buttonAstar.TabIndex = 7;
      this.buttonAstar.Text = "A*";
      this.buttonAstar.UseVisualStyleBackColor = true;
      this.buttonAstar.Click += new System.EventHandler(this.buttonAstar_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(927, 843);
      this.Controls.Add(this.buttonAstar);
      this.Controls.Add(this.buttonDijkstra);
      this.Controls.Add(this.cbRandomWeights);
      this.Controls.Add(this.numericUpDownSeed);
      this.Controls.Add(this.seedText);
      this.Controls.Add(this.numericUpDownBranching);
      this.Controls.Add(this.branchingText);
      this.Controls.Add(this.numericUpDownNodeCount);
      this.Controls.Add(this.nodesText);
      this.Controls.Add(this.mainWindow);
      this.Controls.Add(this.console);
      this.DoubleBuffered = true;
      this.Name = "Form1";
      this.Text = "Pathfinding Demo";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNodeCount)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBranching)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeed)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox console;
    private System.Windows.Forms.Panel mainWindow;
    private System.Windows.Forms.Label nodesText;
    private System.Windows.Forms.NumericUpDown numericUpDownNodeCount;
    private System.Windows.Forms.Label branchingText;
    private System.Windows.Forms.NumericUpDown numericUpDownBranching;
    private System.Windows.Forms.Label seedText;
    private System.Windows.Forms.NumericUpDown numericUpDownSeed;
    private System.Windows.Forms.CheckBox cbRandomWeights;
    private System.Windows.Forms.Button buttonDijkstra;
    private System.Windows.Forms.Button buttonAstar;
  }
}

