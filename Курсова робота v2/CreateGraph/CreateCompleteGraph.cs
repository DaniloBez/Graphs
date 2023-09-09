using System.Windows.Forms;

namespace Випускна_робота.CreateGraph
{
    internal class CreateCompleteGraph : IGraphBuilder
    {
        public void CreateGraph(int numberOfVertices, ref int[,] adjacencyMatrix, ref DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();

            adjacencyMatrix = new int[numberOfVertices, numberOfVertices];
            dataGrid.RowCount = numberOfVertices + 1;
            dataGrid.ColumnCount = numberOfVertices + 1;

            dataGrid.AutoResizeColumns();

            for (int i = 0; i < numberOfVertices; i++)
            {
                dataGrid.Rows[0].Cells[i + 1].Value = i;
                dataGrid.Rows[i + 1].Cells[0].Value = i;
            }

            for (int i = 1; i <= numberOfVertices; i++)
            {
                for (int j = 1; j <= numberOfVertices; j++)
                {
                    if (i == j)
                        adjacencyMatrix[i - 1, j - 1] = 0;
                    else
                        adjacencyMatrix[i - 1, j - 1] = 1;

                    dataGrid.Rows[i].Cells[j].Value = adjacencyMatrix[i - 1, j - 1];
                }
            }

            dataGrid.AutoResizeColumns();
        }
    }
}
