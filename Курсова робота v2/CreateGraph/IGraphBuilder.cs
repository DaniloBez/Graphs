using System.Windows.Forms;

namespace Курсова_робота.CreateGraph
{
    internal interface IGraphBuilder
    {
        void CreateGraph(int numberOfVertices, ref int[,] adjacencyMatrix, ref DataGridView dataGrid);
    }
}
