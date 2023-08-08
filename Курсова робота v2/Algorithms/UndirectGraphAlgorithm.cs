using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Курсова_робота.Algorithms
{
    internal class UndirectGraphAlgorithm : ICycleDetectionAlgorithm
    {
        public IEnumerable<IList> CycleDetection(int vertex, int[,] adjacencyMatrix)
        {
            HashSet<List<int>> allCycles = new HashSet<List<int>>(new ListComparer());
            Stack<int> chainOfPassedVertices = new Stack<int>();

            int numberOfVertices = (int)Math.Sqrt(adjacencyMatrix.Length);
            bool[,] passedVertices = new bool[numberOfVertices, numberOfVertices];
            int vertexChainDepth = 1;
            chainOfPassedVertices.Push(vertex);

            while (vertexChainDepth > 0)
            {
                bool isVertexFound = false;
                int adjacentVertex = 0;

                while (!isVertexFound && adjacentVertex < numberOfVertices)
                {
                    if (adjacencyMatrix[chainOfPassedVertices.Peek(), adjacentVertex] != 0 &&
                        !chainOfPassedVertices.Contains(adjacentVertex) &&
                        !passedVertices[vertexChainDepth, adjacentVertex])
                    {
                        isVertexFound = true;
                    }
                    else
                    {
                        adjacentVertex++;
                    }
                }

                if (isVertexFound)
                {
                    vertexChainDepth++;
                    chainOfPassedVertices.Push(adjacentVertex);
                }
                else
                {
                    if (adjacencyMatrix[chainOfPassedVertices.Peek(), vertex] == 1 && chainOfPassedVertices.Count > 2)
                    {
                        chainOfPassedVertices.Push(vertex);
                        List<int> foundCycle = chainOfPassedVertices.ToList();
                        foundCycle.Reverse();

                        if (!allCycles.Contains(foundCycle))
                        {
                            foundCycle.Reverse();
                            allCycles.Add(foundCycle);
                        }

                        chainOfPassedVertices.Pop();
                    }

                    vertexChainDepth--;
                    passedVertices[vertexChainDepth, chainOfPassedVertices.Pop()] = true;

                    if (numberOfVertices - vertexChainDepth >= 2)
                    {
                        for (int i = 0; i < numberOfVertices; i++)
                        {
                            passedVertices[vertexChainDepth + 1, i] = false;
                        }
                    }
                }
            }

            return allCycles;
        }
    }

    class ListComparer : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int> x, List<int> y)
        {
            return x.SequenceEqual(y);
        }

        public int GetHashCode(List<int> obj)
        {
            int hashCode = 17;
            unchecked
            {
                foreach (int value in obj)
                {
                    hashCode = hashCode * 23 + value.GetHashCode();
                }
            }
            return hashCode;
        }
    }
}
