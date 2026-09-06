/*
 =======================================================================================
 CHALLENGE: UnionFind
 CATEGORY: Shared
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the UnionFind problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test tests/CodingExercises.Tests --filter FullyQualifiedName~CodingExercises.Tests.Shared.UnionFindTests
 =======================================================================================
*/

﻿namespace CodingExercises.Shared
{
    public class UnionFind
    {
        private int[] id;
        private int[] weights;

        public UnionFind(int n)
        {
            id = new int[n];
            weights = new int[n];

            for (int i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }

        public void Union(int p, int q)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public bool Connected(int p, int q)
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }

        public int Find(int i) //path compression
        {
            while (i != id[i])
            {
                //id[i] = id[id[i]]; one pass compression
                i = id[i];
            }
            while (i != id[i]) // 2 pass compression ( more efficient)
            {
                id[i] = i;
            }
            return i;
        }

        public int ConnectedComponents()
        {
            // TODO: Implement your solution here
            throw new NotImplementedException();
        }
    }
}
