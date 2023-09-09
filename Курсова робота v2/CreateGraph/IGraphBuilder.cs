using System.Windows.Forms;

namespace Випускна_робота.CreateGraph
{
    internal interface IGraphBuilder
    {
        void CreateGraph(int numberOfVertices, ref int[,] adjacencyMatrix, ref DataGridView dataGrid);
    }
}
