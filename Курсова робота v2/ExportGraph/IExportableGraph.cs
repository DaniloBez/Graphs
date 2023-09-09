using System.Windows.Forms;

namespace Випускна_робота.ExportGraph
{
    internal interface IExportableGraph
    {
        void ExportGraph(int[,] matrix, SaveFileDialog saveFile);
    }
}
