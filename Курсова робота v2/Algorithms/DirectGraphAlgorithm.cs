using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Випускна_робота.Algorithms
{
    internal class DirectGraphAlgorithm : ICycleDetectionAlgorithm
    {
        public IEnumerable<IList> CycleDetection(int vertex, int[,] adjacencyMatrix)
        {
            HashSet<List<int>> allCycles = new HashSet<List<int>>();
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
                        allCycles.Add(chainOfPassedVertices.ToList());
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
}
