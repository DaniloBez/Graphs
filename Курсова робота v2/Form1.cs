using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Курсова_робота.Algorithms;
using Курсова_робота.Visualizations;
using Курсова_робота.CreateGraph;
using Курсова_робота.ImportGraph;
using Курсова_робота.ExportCycle;
using Курсова_робота.ExportGraph;

namespace Курсова_робота_v2
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
        private void CreateEmptyUndirectedUnweighted_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesUndirectedUnweightedTB.Text);
            adjacencyMatrix = new int[numberOfVertices, numberOfVertices];

            graphBuilder = new CreateEmptyGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV);
        }
        private void UpdateUndirectedUnweighted_Click(object sender, EventArgs e)
        {
            graphVisualization = new UndirectedGraphVisualization();
            graphAlgorithm = new UndirectGraphAlgorithm();

            graphBuilder = new UpdateGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV);

            PastGraphImageUndirectedUnweightedPB.Image = GraphImageUndirectedUnweightedPB.Image;
            GraphImageUndirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageUndirectedUnweightedPB.Width, GraphImageUndirectedUnweightedPB.Height);
        }
        private void CreateCompleteUndirectedUnweighted_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesUndirectedUnweightedTB.Text);

            graphVisualization = new UndirectedGraphVisualization();
            graphAlgorithm = new UndirectGraphAlgorithm();

            graphBuilder = new CreateCompleteGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV);

            PastGraphImageUndirectedUnweightedPB.Image = GraphImageUndirectedUnweightedPB.Image;
            GraphImageUndirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageUndirectedUnweightedPB.Width, GraphImageUndirectedUnweightedPB.Height);
        }
        private void MainMethodUndirectedUnweighted_Click(object sender, EventArgs e)
        {
            FindCycle(CyclesUndirectedUnweightedLB, PastCyclesUndirectedUnweightedLB, VertexNumberUndirectedUnweightedTB, TimerUndirectedUnweightedLbl);
        }
        private void ImportGraphUndirectUnweighted_Click(object sender, EventArgs e)
        {
            graphAlgorithm = new UndirectGraphAlgorithm();
            graphVisualization = new UndirectedGraphVisualization();

            graphImporter = new ImportGraphFromTxt();
            graphImporter.ImportGraph(ref numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV, openFileDialog1);
            NumberOfVerticesUndirectedUnweightedTB.Text = numberOfVertices.ToString();

            PastGraphImageUndirectedUnweightedPB.Image = GraphImageUndirectedUnweightedPB.Image;
            GraphImageUndirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageUndirectedUnweightedPB.Width, GraphImageUndirectedUnweightedPB.Height);
        }
        private void ExportGraphToTxtUndirected_Click(object sender, EventArgs e)
        {
            graphExport = new ExportGraphInTxt();
            graphExport.ExportGraph(adjacencyMatrix, saveFileDialog1);
        }
        private void ExportCycleToTxtUndirected_Click(object sender, EventArgs e)
        {
            cycleExport = new ExportCycleInTxt();
            cycleExport.Export(allCycles, saveFileDialog1);
        }
        private void CreateRandomGraphUndirected_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesUndirectedUnweightedTB.Text);

            graphVisualization = new UndirectedGraphVisualization();
            graphAlgorithm = new UndirectGraphAlgorithm();

            graphBuilder = new CreateRandomUndirectedGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV);

            PastGraphImageUndirectedUnweightedPB.Image = GraphImageUndirectedUnweightedPB.Image;
            GraphImageUndirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageUndirectedUnweightedPB.Width, GraphImageUndirectedUnweightedPB.Height);
        }
        #endregion
        #region DirectedUnweightedGraph
        private void CreateEmptyDirectedUnweighted_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesDirectedUnweightedTB.Text);
            adjacencyMatrix = new int[numberOfVertices, numberOfVertices];

            graphBuilder = new CreateEmptyGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixDirectedUnweightedDGV);
        }
        private void UpdateDirectedUnweighted_Click(object sender, EventArgs e)
        {
            graphVisualization = new DirectedGraphVisualization();
            graphAlgorithm = new DirectGraphAlgorithm();    

            graphBuilder = new UpdateGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixDirectedUnweightedDGV);

            PastGraphImageDirectedUnweightedPB.Image = GraphImageDirectedUnweightedPB.Image;
            GraphImageDirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageDirectedUnweightedPB.Width, GraphImageDirectedUnweightedPB.Height);
        }
        private void CreateCompleteDirectedUnweighted_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesDirectedUnweightedTB.Text);

            graphVisualization = new DirectedGraphVisualization();
            graphAlgorithm = new DirectGraphAlgorithm();

            graphBuilder = new CreateCompleteGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV);

            PastGraphImageDirectedUnweightedPB.Image = GraphImageDirectedUnweightedPB.Image;
            GraphImageDirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageDirectedUnweightedPB.Width, GraphImageDirectedUnweightedPB.Height);
        }
        private void MainMethodDirectedUnweighted_Click(object sender, EventArgs e)
        {
            FindCycle(CyclesDirectedUnweightedLB, PastCyclesDirectedUnweightedLB, VertexNumberDirectedUnweightedTB, TimerDirectedUnweightedLbl);
        }
        private void ImportGraphDirectUnweighted_Click(object sender, EventArgs e)
        {
            graphAlgorithm = new DirectGraphAlgorithm();
            graphVisualization = new DirectedGraphVisualization();

            graphImporter = new ImportGraphFromTxt();
            graphImporter.ImportGraph(ref numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixDirectedUnweightedDGV, openFileDialog1);
            NumberOfVerticesDirectedUnweightedTB.Text = numberOfVertices.ToString();

            PastGraphImageDirectedUnweightedPB.Image = GraphImageDirectedUnweightedPB.Image;
            GraphImageDirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageDirectedUnweightedPB.Width, GraphImageDirectedUnweightedPB.Height);
        }
        private void CreateRandomGraphDirected_Click(object sender, EventArgs e)
        {
            numberOfVertices = int.Parse(NumberOfVerticesDirectedUnweightedTB.Text);

            graphVisualization = new DirectedGraphVisualization();
            graphAlgorithm = new DirectGraphAlgorithm();

            graphBuilder = new CreateRandomDirectedGraph();
            graphBuilder.CreateGraph(numberOfVertices, ref adjacencyMatrix, ref AdjacencyMatrixUndirectedUnweightedDGV);

            PastGraphImageDirectedUnweightedPB.Image = GraphImageDirectedUnweightedPB.Image;
            GraphImageDirectedUnweightedPB.Image = graphVisualization.DrawGraph(adjacencyMatrix, GraphImageDirectedUnweightedPB.Width, GraphImageDirectedUnweightedPB.Height);
        }
        private void ExportGraphToTxtDirected_Click(object sender, EventArgs e)
        {
            graphExport = new ExportGraphInTxt();
            graphExport.ExportGraph(adjacencyMatrix, saveFileDialog1);
        }
        private void ExportCycleToTxtDirected_Click(object sender, EventArgs e)
        {
            cycleExport = new ExportCycleInTxt();
            cycleExport.Export(allCycles, saveFileDialog1);
        }
        #endregion
        #endregion

        #region Programm
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
