namespace GradeBook
{
    /// <summary>
    /// An EvaluationComponent is some specific item for which marks can be earned.
    /// </summary>
    public class EvaluationComponent
    {
        public EvaluationComponent(string name, int weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; set; }
        public int Weight { get; set; }
        public int? PossibleMarks { get; set; } // an int? variable means that this primitive could hold a null value (acts like a reference type instead of a value type)
        public double? EarnedMark { get; set; }
    }
}
