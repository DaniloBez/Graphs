using System.Windows.Forms;

namespace Випускна_робота.ImportGraph
{
    internal interface IGraphImporter
    {
        void ImportGraph(ref int numberOfVertices, ref int[,] adjacencyMatrix, ref DataGridView dataGrid, OpenFileDialog fileDialog);
    }
}
