using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Випускна_робота.Algorithms;
using Випускна_робота.CreateGraph;
using Випускна_робота.ExportCycle;
using Випускна_робота.ExportGraph;
using Випускна_робота.ImportGraph;
using Випускна_робота.Visualizations;

namespace Випускна_робота
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        int numberOfVertices;
        int[,] adjacencyMatrix;
        HashSet<List<int>> allCycles = new HashSet<List<int>>();
        IVizualization graphVisualization;
        ICycleDetectionAlgorithm graphAlgorithm;
        IGraphBuilder graphBuilder;
        IGraphImporter graphImporter;
        IExportableCycle cycleExport;
        IExportableGraph graphExport;
        #endregion

        #region ButtonEvents
        #region UndirectedUnweightedGraph
        private void CreateEmptyUndirectedUnweightedTSMI_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesUndirectedUnweightedTB.Text);
            adjacencyMatrix = new int[numberOfVertices, numberOfVertices];

            graphBuilder = new CreateEmptyGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV);
        }
        private void CreateCompleteUndirectedUnweightedTSMI_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesUndirectedUnweightedTB.Text);

            graphVisualization = new UndirectedGraphVisualization();
            graphAlgorithm = new UndirectGraphAlgorithm();

            graphBuilder = new CreateCompleteGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV);

            PastGraphImageUndirectedUnweightedPB.Image = GraphImageUndirectedUnweightedPB.Image;
            GraphImageUndirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageUndirectedUnweightedPB.Width, GraphImageUndirectedUnweightedPB.Height);
        }
        private void CreateRandomGraphUndirectedTSMI_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesUndirectedUnweightedTB.Text);

            graphVisualization = new UndirectedGraphVisualization();
            graphAlgorithm = new UndirectGraphAlgorithm();

            graphBuilder = new CreateRandomUndirectedGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV);

            PastGraphImageUndirectedUnweightedPB.Image = GraphImageUndirectedUnweightedPB.Image;
            GraphImageUndirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageUndirectedUnweightedPB.Width, GraphImageUndirectedUnweightedPB.Height);
        }
        private void UpdateUndirectedUnweightedГрафTSMI_Click(object sender, EventArgs e)
        {
            graphVisualization = new UndirectedGraphVisualization();
            graphAlgorithm = new UndirectGraphAlgorithm();

            graphBuilder = new UpdateGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV);

            PastGraphImageUndirectedUnweightedPB.Image = GraphImageUndirectedUnweightedPB.Image;
            GraphImageUndirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageUndirectedUnweightedPB.Width, GraphImageUndirectedUnweightedPB.Height);
        }
        private void MainMethodUndirectedUnweightedTSMI_Click(object sender, EventArgs e)
        {
            FindCycle(CyclesUndirectedUnweightedLB, PastCyclesUndirectedUnweightedLB, VertexNumberUndirectedUnweightedTB, TimerUndirectedUnweightedLbl);
        }
        private void ImportGraphUndirectUnweightedTSMI_Click(object sender, EventArgs e)
        {
            graphAlgorithm = new UndirectGraphAlgorithm();
            graphVisualization = new UndirectedGraphVisualization();

            graphImporter = new ImportGraphFromTxt();
            graphImporter.ImportGraph(ref numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV, openFileDialog1);
            NumberOfVerticesUndirectedUnweightedTB.Text = numberOfVertices.ToString();

            PastGraphImageUndirectedUnweightedPB.Image = GraphImageUndirectedUnweightedPB.Image;
            GraphImageUndirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageUndirectedUnweightedPB.Width, GraphImageUndirectedUnweightedPB.Height);
        }
        private void ExportGraphToTxtUndirectedTSMI_Click(object sender, EventArgs e)
        {
            graphExport = new ExportGraphInTxt();
            graphExport.ExportGraph(adjacencyMatrix, saveFileDialog1);
        }
        private void ExportCycleToTxtUndirectedTSMI_Click(object sender, EventArgs e)
        {
            cycleExport = new ExportCycleInTxt();
            cycleExport.Export(allCycles, saveFileDialog1);
        }
        #endregion
        #region DirectedUnweightedGraph
        private void CreateEmptyDirectedUnweightedTSMI_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesDirectedUnweightedTB.Text);
            adjacencyMatrix = new int[numberOfVertices, numberOfVertices];

            graphBuilder = new CreateEmptyGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixDirectedUnweightedDGV);
        }
        private void CreateCompleteDirectedUnweightedTSMI_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesDirectedUnweightedTB.Text);

            graphVisualization = new DirectedGraphVisualization();
            graphAlgorithm = new DirectGraphAlgorithm();

            graphBuilder = new CreateCompleteGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixDirectedUnweightedDGV);

            PastGraphImageDirectedUnweightedPB.Image = GraphImageDirectedUnweightedPB.Image;
            GraphImageDirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageDirectedUnweightedPB.Width, GraphImageDirectedUnweightedPB.Height);
        }
        private void CreateRandomGraphDirectedTSMI_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesDirectedUnweightedTB.Text);

            graphVisualization = new DirectedGraphVisualization();
            graphAlgorithm = new DirectGraphAlgorithm();

            graphBuilder = new CreateRandomDirectedGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixDirectedUnweightedDGV);

            PastGraphImageDirectedUnweightedPB.Image = GraphImageDirectedUnweightedPB.Image;
            GraphImageDirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageDirectedUnweightedPB.Width, GraphImageDirectedUnweightedPB.Height);
        }
        private void UpdateDirectedUnweightedГрафTSMI_Click(object sender, EventArgs e)
        {
            graphVisualization = new DirectedGraphVisualization();
            graphAlgorithm = new DirectGraphAlgorithm();

            graphBuilder = new UpdateGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixDirectedUnweightedDGV);

            PastGraphImageDirectedUnweightedPB.Image = GraphImageDirectedUnweightedPB.Image;
            GraphImageDirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageDirectedUnweightedPB.Width, GraphImageDirectedUnweightedPB.Height);
        }
        private void MainMethodDirectedUnweightedTSMI_Click(object sender, EventArgs e)
        {
            FindCycle(CyclesDirectedUnweightedLB, PastCyclesDirectedUnweightedLB, VertexNumberDirectedUnweightedTB, TimerDirectedUnweightedLbl);
        }
        private void ImportGraphDirectUnweightedTSMI_Click(object sender, EventArgs e)
        {
            graphAlgorithm = new DirectGraphAlgorithm();
            graphVisualization = new DirectedGraphVisualization();

            graphImporter = new ImportGraphFromTxt();
            graphImporter.ImportGraph(ref numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixDirectedUnweightedDGV, openFileDialog1);
            NumberOfVerticesDirectedUnweightedTB.Text = numberOfVertices.ToString();

            PastGraphImageDirectedUnweightedPB.Image = GraphImageDirectedUnweightedPB.Image;
            GraphImageDirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageDirectedUnweightedPB.Width, GraphImageDirectedUnweightedPB.Height);
        }
        private void ExportGraphToTxtDirectedTSMI_Click(object sender, EventArgs e)
        {
            graphExport = new ExportGraphInTxt();
            graphExport.ExportGraph(adjacencyMatrix, saveFileDialog1);
        }
        private void ExportCycleToTxtDirectedTSMI_Click(object sender, EventArgs e)
        {
            cycleExport = new ExportCycleInTxt();
            cycleExport.Export(allCycles, saveFileDialog1);
        }
        #endregion
        #endregion

        #region Programm

        private void Form1_Load(object sender, EventArgs e) => GraphImageDirectedUnweightedLbl.BringToFront();
        private void FindCycle(ListBox listBox1, ListBox listBox2, TextBox textBox, Label label)
        {
            listBox2.BeginUpdate();
            listBox2.Items.Clear();
            listBox2.Items.AddRange(listBox1.Items);
            listBox2.EndUpdate();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            int x = int.Parse(textBox.Text);

            allCycles = (HashSet<List<int>>)graphAlgorithm.CycleDetection(x, adjacencyMatrix);
            ShowCycle(listBox1);

            sw.Stop();

            label.Text = $"Час виконання программи: {sw.Elapsed:mm':'ss':'fff}";
        }

        public void ShowCycle(ListBox list)
        {
            list.BeginUpdate();
            list.Items.Clear();

            if (allCycles.Count == 0)
                list.Items.Add(" - ");
            else
            {
                int i = 0;
                foreach (var item in allCycles)
                {
                    string s = $"{i + 1})";
                    item.Reverse();

                    foreach (var item2 in item)
                        s += " " + item2;

                    list.Items.Add(s);
                    i++;
                }
            }
            list.EndUpdate();
        }

        #endregion
    }
}
