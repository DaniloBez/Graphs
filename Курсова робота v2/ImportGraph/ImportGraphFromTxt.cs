using System.Windows.Forms;
using System.IO;

namespace Випускна_робота.ImportGraph
{
    internal class ImportGraphFromTxt : IGraphImporter
    {
        public void ImportGraph(ref int numberOfVertices, ref int[,] adjacencyMatrix, ref DataGridView dataGrid, OpenFileDialog fileDialog)
        {
            fileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            fileDialog.ShowDialog();
            string path = fileDialog.FileName;

            string[] lines = File.ReadAllLines(path);

            numberOfVertices = int.Parse(lines[0]);

            adjacencyMatrix = new int[numberOfVertices, numberOfVertices];
            dataGrid.RowCount = numberOfVertices + 1;
            dataGrid.ColumnCount = numberOfVertices + 1;

            for (int i = 0; i < numberOfVertices; i++)
            {
                dataGrid.Rows[0].Cells[i + 1].Value = i;
                dataGrid.Rows[i + 1].Cells[0].Value = i;
            }

            for (int i = 1; i <= numberOfVertices; i++)
            {
                string[] line = lines[i].Split(' ');

                for (int j = 1; j <= numberOfVertices; j++)
                {
                    adjacencyMatrix[i - 1, j - 1] = int.Parse(line[j - 1]);

                    dataGrid.Rows[i].Cells[j].Value = adjacencyMatrix[i - 1, j - 1];
                }
            }

            dataGrid.AutoResizeColumns();
        }
    }
}
