using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Випускна_робота.ExportCycle
{
    internal class ExportCycleInTxt : IExportableCycle
    {
        public void Export(HashSet<List<int>> cycles, SaveFileDialog saveFile)
        {
            saveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFile.ShowDialog();
            string path = saveFile.FileName;

            string[] lines = new string[cycles.Count];
            if (cycles.Count == 0)
                File.AppendAllText(path, "У данному графі немає циклів");
            else
            {
                int i = 0;
                foreach (var item in cycles)
                {
                    lines[i] = $"{i + 1})";
                    item.Reverse();

                    foreach (var item2 in item)
                        lines[i] += " " + item2;

                    i++;
                }
                File.AppendAllLines(path, lines);
            }
        }
    }
}
