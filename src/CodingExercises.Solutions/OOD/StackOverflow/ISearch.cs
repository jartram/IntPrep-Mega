using System.Collections.Generic;

namespace CodingExercises.Solutions.OOD.StackOverflow
{
    interface ISearch
    {
        IEnumerable<Question> Search(string query);
    }
}
