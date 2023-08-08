using System.Windows.Forms;

namespace Курсова_робота.ImportGraph
{
    internal interface IGraphImporter
    {
        void ImportGraph(ref int numberOfVertices, ref int[,] adjacencyMatrix, ref DataGridView dataGrid, OpenFileDialog fileDialog);
    }
}
