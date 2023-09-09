using System.Windows.Forms;

namespace Випускна_робота.CreateGraph
{
    internal class UpdateGraph : IGraphBuilder
    {
        public void CreateGraph(int numberOfVertices, ref int[,] adjacencyMatrix, ref DataGridView dataGrid)
        {
            for (int i = 1; i <= numberOfVertices; i++)
            {
                for (int j = 1; j <= numberOfVertices; j++)
                    adjacencyMatrix[i - 1, j - 1] = int.Parse(dataGrid.Rows[i].Cells[j].Value.ToString());
            }
        }
    }
}
