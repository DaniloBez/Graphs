using System.Collections.Generic;
using System.Linq;

namespace Курсова_робота
{
    internal class Algorithm
    {

        bool[,] passedVertices;


        public void StartHs(int vertex, int numberOfVertices, int[,] adjacencyMatrix, ref HashSet<List<int>> allCycles)
        {
            Stack<int> chainOfPassedVertices = new Stack<int>(); 
            chainOfPassedVertices.Push(vertex); 

            Hs(chainOfPassedVertices, vertex, numberOfVertices, adjacencyMatrix, ref allCycles);
        }


        private void Hs(Stack<int> chainOfPassedVertices, int currentVertex, int numberOfVertices, int[,] adjacencyMatrix, ref HashSet<List<int>> allCycles)
        {
            if (chainOfPassedVertices.Count > 2 && currentVertex == chainOfPassedVertices.ElementAt(0))
            {
                var intListEqualityComparer = new IntListEqualityComparer();
                var foundCycle = chainOfPassedVertices.ToList();
                foundCycle.Reverse();
                foundCycle.Add(foundCycle[0]);
                if (!allCycles.Contains(foundCycle, intListEqualityComparer))
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
                    Hs(chainOfPassedVertices, i, numberOfVertices, adjacencyMatrix, ref allCycles);
                    chainOfPassedVertices.Pop();
                }
            }
        }

        //Починаємо з пошуку циклів для заданої вершини графу.
        public void StartFindingCyclesRecursiveOptimized(int vertex, int numberOfVertices, int[,] adjacencyMatrix, ref List<List<int>> allCycles)
        {
            Stack<int> chainOfPassedVertices = new Stack<int>(); //Створюємо стек, в якому зберігаємо вершини, які ми вже проходили.
            chainOfPassedVertices.Push(vertex); //Додаємо поточну вершину в стек.

            FindingCyclesRecursiveOptimized(chainOfPassedVertices, vertex, numberOfVertices, adjacencyMatrix, ref allCycles); // Викликаємо метод, який знаходить цикли в графі з початковою вершиною.
        }


        private void FindingCyclesRecursiveOptimized(Stack<int> chainOfPassedVertices, int currentVertex, int numberOfVertices, int[,] adjacencyMatrix, ref List<List<int>> allCycles)
        {
            //Якщо в chainOfPassedVertices є більше 2 вершин і поточна вершина currentVertex дорівнює початковій вершині, то ми знайшли цикл.
            if (chainOfPassedVertices.Count > 2 && currentVertex == chainOfPassedVertices.ElementAt(0))
            {
                List<int> foundCycle = chainOfPassedVertices.ToList();//Створюємо список, куди додаємо всі вершини зі стеку.
                foundCycle.Reverse();//еревертаємо його та додаємо до нього початкову вершину
                foundCycle.Add(foundCycle[0]);
                if (!allCycles.Any(cycle => foundCycle.SequenceEqual(cycle)))//Якщо такий цикл ще не доданий до списку, то додаємо його туди.
                {
                    foundCycle.Reverse();
                    allCycles.Add(foundCycle);
                }
            }

            //Перебираємо всі вершини графу 
            for (int i = 0; i < numberOfVertices; i++)
            {
                //Якщо з поточної вершини є ребро до вершини "i" і ми ще не проходили через неї, то додаємо вершину "i" в стек, викликаємо метод FindingCyclesRecursiveOptimized для вершини "i", видаляємо вершину "i" зі стеку за допомогою методу Pop().
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
            FindingCyclesRecursive(chainOfPassedVertices, vertex, vertex, numberOfVertices, adjacencyMatrix, ref allCycles);
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
                    if (ListsAreEquivalentOptimized(foundCycle, allCycles[i]))
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


        public void StartFindingCyclesOptimized(int vertexNumber, int numVertices, int[,] adjacencyMatrix, ref List<List<int>> allCycles)
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
                            if (ListsAreEquivalentOptimized(foundCycle, cycle))
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

        private bool ListsAreEquivalentOptimized(List<int> list1, List<int> list2)
        {
            List<int> copyList1 = new List<int>(list1);
            List<int> copyList2 = new List<int>(list2);
            copyList2.Reverse();
            return copyList1.SequenceEqual(copyList2);
        }

    }

    public class IntListEqualityComparer : IEqualityComparer<List<int>>
    {
        public bool Equals(List<int> x, List<int> y)
        {
            if (x == null || y == null)
            {
                return x == null && y == null;
            }

            if (x.Count != y.Count)
            {
                return false;
            }

            for (int i = 0; i < x.Count; i++)
            {
                if (x[i] != y[i])
                {
                    return false;
                }
            }

            return true;
        }

        public int GetHashCode(List<int> obj)
        {
            unchecked
            {
                int hash = 17;
                foreach (int i in obj)
                {
                    hash = hash * 23 + i.GetHashCode();
                }
                return hash;
            }
        }
    }
}
