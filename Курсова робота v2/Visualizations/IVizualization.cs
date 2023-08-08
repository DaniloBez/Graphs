using System.Drawing;

namespace Курсова_робота.Visualizations
{
    internal interface IVizualization
    {
        Image DrawGraph(int[,] adjacencyMatrix, int Width, int Height);
    }
}
