using System.Collections.Generic;

namespace GradeBook
{
    /// <summary>
    /// An EvaluationGroup is a set of one or more evaluation component that may or may not need to be passed as a whole in order to qualify for a passing grade.
    /// </summary>
    public class EvaluationGroup
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int? PassMark { get; set; }
        public List<EvaluationComponent> Items { get; set; }
    }
}
