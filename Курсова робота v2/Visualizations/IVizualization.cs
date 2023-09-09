using System.Drawing;

namespace Випускна_робота.Visualizations
{
    internal interface IVizualization
    {
        Image DrawGraph(int[,] adjacencyMatrix, int Width, int Height);
    }
}
