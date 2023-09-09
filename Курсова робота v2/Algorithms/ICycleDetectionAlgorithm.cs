using System.Collections;
using System.Collections.Generic;

namespace Випускна_робота.Algorithms
{
    internal interface ICycleDetectionAlgorithm
    {
        IEnumerable<IList> CycleDetection(int vertex, int[,] adjacencyMatrix);
    }
}
