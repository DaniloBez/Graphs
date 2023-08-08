using System.Collections.Generic;
using System.Windows.Forms;

namespace Курсова_робота.ExportCycle
{
    internal interface IExportableCycle
    {
        void Export(HashSet<List<int>> cycle, SaveFileDialog saveFile);
    }
}
