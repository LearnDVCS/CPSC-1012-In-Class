using System.Collections.Generic; // List<T>

namespace GradeBook
{
    /// <summary>
    /// An EvaluationGroup is a set of one or more evaluation compoennts that may or may not need to be passed as a whole in order to qualify for a passing grade.
    /// </summary>
    public class EvaluationGroup
    {
        public EvaluationGroup(string name, int weight)
        {
            Name = name;
            Weight = weight;
            Items = new List<EvaluationComponent>(); // An empty list
        }

        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int? PassMark { get; set; }
        public List<EvaluationComponent> Items { get; set; }
    }
}
