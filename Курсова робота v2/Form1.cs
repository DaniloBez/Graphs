using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Курсова_робота;

namespace Курсова_робота_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            graphVisualization = new Visualization();
            graphAlgorithm = new Algorithm();
        }

        #region Variables
        int numberOfVertices;
        int[,] adjacencyMatrix;
        List<List<int>> allCycles = new List<List<int>>();
        HashSet<List<int>> hs = new HashSet<List<int>>();
        Visualization graphVisualization;
        Algorithm graphAlgorithm;
        #endregion

        #region CreateGraph
        private void CreateEmptyGraph_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            numberOfVertices = int.Parse(textBox1.Text);
            adjacencyMatrix = new int[numberOfVertices, numberOfVertices];
            dataGridView1.RowCount = numberOfVertices + 1;
            dataGridView1.ColumnCount = numberOfVertices + 1;

            for (int i = 0; i < numberOfVertices; i++)
            {
                dataGridView1.Rows[0].Cells[i + 1].Value = i;
                dataGridView1.Rows[i + 1].Cells[0].Value = i;
            }

            dataGridView1.AutoResizeColumns();
        }

        private void UpdateGraph_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= numberOfVertices; i++)
            {
                for (int j = 1; j <= numberOfVertices; j++)
                    adjacencyMatrix[i - 1, j - 1] = int.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
            }

            pictureBox2.Image = pictureBox1.Image;
            graphVisualization.StartVisualization(numberOfVertices, adjacencyMatrix, pictureBox1);
        }

        private void CreateCompleteGraph_Click(object sender, EventArgs e)//створює масив у якому усі вершини суміжні усім вершинам
        {
            numberOfVertices = int.Parse(textBox1.Text);
            adjacencyMatrix = new int[0, 0];

            dataGridView1.Rows.Clear();

            adjacencyMatrix = new int[numberOfVertices, numberOfVertices];
            dataGridView1.RowCount = numberOfVertices + 1;
            dataGridView1.ColumnCount = numberOfVertices + 1;

            dataGridView1.AutoResizeColumns();

            for (int i = 0; i < numberOfVertices; i++)
            {
                dataGridView1.Rows[0].Cells[i + 1].Value = i;
                dataGridView1.Rows[i + 1].Cells[0].Value = i;
            }

            for (int i = 1; i <= numberOfVertices; i++)
            {
                for (int j = 1; j <= numberOfVertices; j++)
                {
                    if (i == j)
                        adjacencyMatrix[i - 1, j - 1] = 0;
                    else
                        adjacencyMatrix[i - 1, j - 1] = 1;

                    dataGridView1.Rows[i].Cells[j].Value = adjacencyMatrix[i - 1, j - 1];
                }
            }

            dataGridView1.AutoResizeColumns();

            pictureBox2.Image = pictureBox1.Image;
            graphVisualization.StartVisualization(numberOfVertices, adjacencyMatrix, pictureBox1);
        }
        #endregion

        #region Programm
        private void CalculateGraph_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            foreach (var item in listBox1.Items)
                listBox2.Items.Add(item);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            allCycles.Clear();
            hs.Clear();
            int x = int.Parse(textBox2.Text);

            if (radioButton1.Checked)
            {
                graphAlgorithm.StartFindingCyclesRecursiveOptimized(x, numberOfVertices, adjacencyMatrix, ref allCycles);
                ShowCyclec();
            }
            if (radioButton2.Checked)
            {
                graphAlgorithm.StartFindingCyclesRecursive(x, numberOfVertices, adjacencyMatrix, ref allCycles);
                ShowCyclec();
            }
            if (radioButton3.Checked)
            {
                graphAlgorithm.StartFindingCyclesOptimized(x, numberOfVertices, adjacencyMatrix, ref allCycles);
                ShowCyclec();
            }
            if (radioButton4.Checked)
            {
                graphAlgorithm.StartFindingCycles(x, numberOfVertices, adjacencyMatrix, ref allCycles);
                ShowCyclec();
            }
            if (radioButton5.Checked)
            {
                graphAlgorithm.StartHs(x, numberOfVertices, adjacencyMatrix, ref hs);
                ShowH();
            }

            sw.Stop();

            label6.Text = $"Час виконання программи: {sw.Elapsed.ToString("mm':'ss':'fff")}";

        }


        void ShowCyclec()
        {
            listBox1.Items.Clear();

            if (allCycles.Count == 0)
                listBox1.Items.Add(" - ");
            else
            {
                for (int i = 0; i < allCycles.Count; i++)
                {
                    string s = $"{i + 1})";
                    allCycles[i].Reverse();

                    foreach (var item in allCycles[i])
                        s += " " + item;

                    listBox1.Items.Add(s);
                }
            }
        }

        void ShowH()
        {
            listBox1.Items.Clear();
            var displayList = new List<string>();
            if (hs.Count == 0)
                displayList.Add(" - ");
            else
            {
                int i = 0;
                foreach (var item in hs)
                {
                    item.Reverse();
                    string s = $"{i + 1}) {String.Join(" ", item)}";

                    displayList.Add(s);
                    i++;
                }
            }
            listBox1.Items.AddRange(displayList.ToArray());

            #endregion
        }
    }
}
