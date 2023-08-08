using System;
using System.Windows.Forms;

namespace Курсова_робота.CreateGraph
{
    internal class CreateRandomUndirectedGraph : IGraphBuilder
    {
        public void CreateGraph(int numberOfVertices, ref int[,] adjacencyMatrix, ref DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            Random random = new Random();   

            adjacencyMatrix = new int[numberOfVertices, numberOfVertices];
            dataGrid.RowCount = numberOfVertices + 1;
            dataGrid.ColumnCount = numberOfVertices + 1;

            dataGrid.AutoResizeColumns();

            for (int i = 0; i < numberOfVertices; i++)
            {
                dataGrid.Rows[0].Cells[i + 1].Value = i;
                dataGrid.Rows[i + 1].Cells[0].Value = i;
            }

            for (int i = 1; i <= numberOfVertices; i++)
            {
                for (int j = i; j <= numberOfVertices; j++)
                {
                    if (i == j)
                    {
                        adjacencyMatrix[i - 1, j - 1] = 0;
                        dataGrid.Rows[j].Cells[i].Value = 0;
                    }
                    else
                    {
                        int randomValue = random.Next(2);
                        adjacencyMatrix[i - 1, j - 1] = randomValue;
                        adjacencyMatrix[j - 1, i - 1] = randomValue;

                        dataGrid.Rows[i].Cells[j].Value = randomValue;
                        dataGrid.Rows[j].Cells[i].Value = randomValue;
                    } 
                }
            }

            dataGrid.AutoResizeColumns();
        }
    }
}
