using System.Windows.Forms;

namespace Курсова_робота.CreateGraph
{
    internal class CreateEmptyGraph : IGraphBuilder
    {
        public void CreateGraph(int numberOfVertices, ref int[,] adjacencyMatrix, ref DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            dataGrid.RowCount = numberOfVertices + 1;
            dataGrid.ColumnCount = numberOfVertices + 1;

            for (int i = 0; i < numberOfVertices; i++)
            {
                dataGrid.Rows[0].Cells[i + 1].Value = i;
                dataGrid.Rows[i + 1].Cells[0].Value = i;
            }

            dataGrid.AutoResizeColumns();
        }
    }
}
