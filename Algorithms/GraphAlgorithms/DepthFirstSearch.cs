﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GraphAlgorithms
{
    public static class DepthFirstSearch
    {
        public static bool[] Run(bool[,] graph, int start)
        {
            int n = graph.GetLength(0);
            if (n != graph.GetLength(1))
                throw new ArgumentException(nameof(graph));

            if (start >= n)
                throw new ArgumentException(nameof(start));

            bool[] visited = new bool[n];

            DepthFirstSearch.Search(graph, n, start, visited);
            return visited;
        }

        private static void Search(bool[,] graph, int n, int current, bool[] visited)
        {
            if (visited[current])
                return;

            visited[current] = true;

            for(int i = 0; i < n; i++)
            {
                if (graph[current, i])
                    DepthFirstSearch.Search(graph, n, i, visited);
            }
        }
    }
}
