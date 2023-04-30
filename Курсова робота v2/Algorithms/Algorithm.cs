using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова_робота
{
    internal class Algorithm
    {

        bool[,] passedVertices;

        public void StartFindingCyclesRecursiveOptimized(int vertex, int numberOfVertices, int[,] adjacencyMatrix, ref List<List<int>> allCycles)
        {
            Stack<int> chainOfPassedVertices = new Stack<int>();
            chainOfPassedVertices.Push(vertex);

            FindingCyclesRecursiveOptimized(chainOfPassedVertices, vertex, numberOfVertices, adjacencyMatrix, ref allCycles);
        }


        private void FindingCyclesRecursiveOptimized(Stack<int> chainOfPassedVertices, int currentVertex, int numberOfVertices, int[,] adjacencyMatrix, ref List<List<int>> allCycles)
        {
            if (chainOfPassedVertices.Count > 2 && currentVertex == chainOfPassedVertices.ElementAt(0))
            {
                var foundCycle = chainOfPassedVertices.ToList();
                foundCycle.Reverse();
                foundCycle.Add(foundCycle[0]);
                if (!allCycles.Any(cycle => foundCycle.SequenceEqual(cycle)))
                {
                    foundCycle.Reverse();
                    allCycles.Add(foundCycle);
                }
            }

            for (int i = 0; i < numberOfVertices; i++)
            {
                if (adjacencyMatrix[currentVertex, i] == 1 && !chainOfPassedVertices.Contains(i))
                {
                    chainOfPassedVertices.Push(i);
                    FindingCyclesRecursiveOptimized(chainOfPassedVertices, i, numberOfVertices, adjacencyMatrix, ref allCycles);
                    chainOfPassedVertices.Pop();
                }
            }
        }


        public void StartFindingCyclesRecursive(int vertex, int numberOfVertices, int[,] adjacencyMatrix, ref List<List<int>> allCycles)
        {
            passedVertices = new bool[numberOfVertices + 1, numberOfVertices + 1];
            var chainOfPassedVertices = new Stack<int>();
            chainOfPassedVertices.Push(vertex);

            for (int i = 0; i < numberOfVertices; i++)
            {
                if (adjacencyMatrix[vertex, i] == 1 && !passedVertices[1, i])
                {
                    chainOfPassedVertices.Push(i);
                    FindingCyclesRecursive(chainOfPassedVertices, i, vertex, numberOfVertices, adjacencyMatrix, ref allCycles);
                    chainOfPassedVertices.Pop();
                }
            }
        }

        private void FindingCyclesRecursive(Stack<int> chainOfPassedVertices, int currentVertex, int vertex_number, int numberOfVertices, int[,] adjacencyMatrix, ref List<List<int>> allCycles)
        {
            passedVertices[chainOfPassedVertices.Count, currentVertex] = true;

            if (chainOfPassedVertices.Count > 2 && adjacencyMatrix[currentVertex, vertex_number] == 1)
            {
                chainOfPassedVertices.Push(vertex_number);
                List<int> foundCycle = chainOfPassedVertices.ToList();
                bool isListsAreNotEquivalent = true;

                for (int i = 0; i < allCycles.Count; i++)
                {
                    if (ListsAreEquivalent(foundCycle, allCycles[i]))
                    {
                        isListsAreNotEquivalent = false;
                        break;
                    }
                }
                if (isListsAreNotEquivalent)
                    allCycles.Add(foundCycle);
                chainOfPassedVertices.Pop();
            }

            for (int i = 0; i < numberOfVertices; i++)
            {
                if (adjacencyMatrix[currentVertex, i] == 1 && !chainOfPassedVertices.Contains(i) && !passedVertices[chainOfPassedVertices.Count + 1, i])
                {
                    chainOfPassedVertices.Push(i);
                    FindingCyclesRecursive(chainOfPassedVertices, i, vertex_number, numberOfVertices, adjacencyMatrix, ref allCycles);
                    chainOfPassedVertices.Pop();
                }
            }

            passedVertices[chainOfPassedVertices.Count, currentVertex] = false;
            return;
        }


        public void StartFindingCycles(int vertex_number, int numberOfVertices, int[,] adjacencyMatrix, ref List<List<int>> allCycles)
        {
            passedVertices = new bool[numberOfVertices, numberOfVertices];
            int adjacentVertex, vertexChainDepth = 1;
            bool isVertexFound;
            Stack<int> chainOfPassedVertices = new Stack<int>();
            chainOfPassedVertices.Push(vertex_number);

            while (vertexChainDepth > 0)
            {
                adjacentVertex = 0;
                isVertexFound = false;

                while (!isVertexFound && adjacentVertex < numberOfVertices)
                {
                    if (adjacencyMatrix[chainOfPassedVertices.Peek(), adjacentVertex] != 0 && !chainOfPassedVertices.Contains(adjacentVertex) && !passedVertices[vertexChainDepth, adjacentVertex])
                        isVertexFound = true;
                    else
                        adjacentVertex++;
                }

                if (isVertexFound)
                {
                    vertexChainDepth++;
                    chainOfPassedVertices.Push(adjacentVertex);
                }
                else
                {
                    if (adjacencyMatrix[vertex_number, chainOfPassedVertices.Peek()] == 1 && chainOfPassedVertices.Count > 2)
                    {
                        chainOfPassedVertices.Push(vertex_number);
                        var foundCycle = chainOfPassedVertices.ToList();
                        bool isListsAreNotEquivalent = true;

                        for (int i = 0; i < allCycles.Count; i++)
                        {
                            if (ListsAreEquivalent(foundCycle, allCycles[i]))
                            {
                                isListsAreNotEquivalent = false;
                                break;
                            }
                        }
                        if (isListsAreNotEquivalent)
                            allCycles.Add(foundCycle);
                        chainOfPassedVertices.Pop();
                    }

                    vertexChainDepth--;
                    passedVertices[vertexChainDepth, chainOfPassedVertices.Pop()] = true;

                    if (numberOfVertices - vertexChainDepth >= 2)
                    {
                        for (int i = 0; i < numberOfVertices; i++)
                            passedVertices[vertexChainDepth + 1, i] = false;
                    }
                }
            }
        }


        private bool ListsAreEquivalent(List<int> list1, List<int> list2)
        {
            List<int> list3 = (from item in list1 select item).ToList();
            List<int> list4 = (from item in list2 select item).ToList();
            list4.Reverse();

            return list3.SequenceEqual(list4);
        }


        public void FindCycles(int vertexNumber, int numVertices, int[,] adjacencyMatrix, ref List<List<int>> allCycles)
        {
            bool[,] passedVertices = new bool[numVertices, numVertices];
            int vertexChainDepth = 1;
            Stack<int> chainOfPassedVertices = new Stack<int>();
            chainOfPassedVertices.Push(vertexNumber);
            while (vertexChainDepth > 0)
            {
                bool isVertexFound = false;
                int adjacentVertex = 0;

                while (!isVertexFound && adjacentVertex < numVertices)
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
                    if (adjacencyMatrix[vertexNumber, chainOfPassedVertices.Peek()] == 1 && chainOfPassedVertices.Count > 2)
                    {
                        chainOfPassedVertices.Push(vertexNumber);
                        List<int> foundCycle = chainOfPassedVertices.ToList();
                        bool isListsAreNotEquivalent = true;

                        foreach (List<int> cycle in allCycles)
                        {
                            if (ListsAreEquivalent2(foundCycle, cycle))
                            {
                                isListsAreNotEquivalent = false;
                                break;
                            }
                        }

                        if (isListsAreNotEquivalent)
                        {
                            allCycles.Add(foundCycle);
                        }

                        chainOfPassedVertices.Pop();
                    }

                    vertexChainDepth--;
                    passedVertices[vertexChainDepth, chainOfPassedVertices.Pop()] = true;

                    if (numVertices - vertexChainDepth >= 2)
                    {
                        for (int i = 0; i < numVertices; i++)
                        {
                            passedVertices[vertexChainDepth + 1, i] = false;
                        }
                    }
                }
            }
        }

        private bool ListsAreEquivalent2(List<int> list1, List<int> list2)
        {
            List<int> copyList1 = new List<int>(list1);
            List<int> copyList2 = new List<int>(list2);
            copyList2.Reverse();
            return copyList1.SequenceEqual(copyList2);
        }

    }
}
