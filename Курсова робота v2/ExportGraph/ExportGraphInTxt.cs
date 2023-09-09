using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Випускна_робота.ExportGraph
{
    internal class ExportGraphInTxt : IExportableGraph
    {
        public void ExportGraph(int[,] matrix, SaveFileDialog saveFile)
        {
            int numberOfVericies = (int)Math.Sqrt(matrix.Length);

            saveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFile.ShowDialog();
            string path = saveFile.FileName;

            List<string> lines = new List<string>
            {
                numberOfVericies.ToString()
            };

            string s;
            for (int i = 0; i < numberOfVericies; i++)
            {
                s = "";

                for (int j = 0; j < numberOfVericies; j++)
                {
                    s += matrix[i, j] + " ";
                }
                lines.Add(s);
            }

            File.AppendAllLines(path, lines);
        }
    }
}
