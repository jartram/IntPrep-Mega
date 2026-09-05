/*
 =======================================================================================
 CHALLENGE: FlattenNestedListIterator
 CATEGORY: MicrosoftExcercises / Medium
 SOURCE: N/A
 
 DESCRIPTION:
 Solve the FlattenNestedListIterator problem as specified. Implement the methods below to pass
 all automated unit tests.
 
 VALIDATION COMMAND:
 dotnet test --filter FullyQualifiedName~CodingExercises.Tests.MicrosoftExcercises.FlattenNestedListIteratorTests
 =======================================================================================
*/

using System.Collections.Generic;

namespace CodingExercises.MicrosoftExcercises.Medium
{
    public class FlattenNestedListIterator
    {
        public class NestedIterator
        {
            private int[] flatten;
            private int current;

            public NestedIterator(IList<NestedInteger> nestedList)
            {
                var flattenList = new List<int>();
                current = 0;
                foreach (var item in nestedList)
                {
                    AddItem(item, flattenList);
                }

                flatten = flattenList.ToArray();
            }

            public bool HasNext()
            {
                return current < flatten.Length;
            }

            public int Next()
            {
                return flatten[current++];
            }

            private void AddItem(NestedInteger item, IList<int> list)
            {
                if (item.IsInteger())
                {
                    list.Add(item.GetInteger());
                }
                else
                {
                    foreach (var nested in item.GetList())
                    {
                        AddItem(nested, list);
                    }
                }
            }
        }
    }


    // dummy, leetcode public class is not public
    public class NestedInteger
    {
        public IList<NestedInteger> GetList()
        {
            return null;
        }

        public int GetInteger() { return 1; }

        public bool IsInteger() { return false; }
    }
}
