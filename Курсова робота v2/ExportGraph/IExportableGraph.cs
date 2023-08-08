using System.Windows.Forms;

namespace Курсова_робота.ExportGraph
{
    internal interface IExportableGraph
    {
        void ExportGraph(int[,] matrix, SaveFileDialog saveFile);
    }
}
