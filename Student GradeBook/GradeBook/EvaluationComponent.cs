namespace GradeBook
{
    /// <summary>
    /// An EvaluationComponent is some specific item for which marks can be earned.
    /// </summary>
    public class EvaluationComponent
    {
        public EvaluationComponent(string name, int weight)
        {
            // up-front validation
            if (weight <= 0 || weight > 100)
                throw new System.Exception("Invalid weight");

            Name = name;
            Weight = weight;
        }

        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int? PossibleMarks { get; set; } // an int? variable means that this primitive could hold a null value (acty like a reference type)
        public double? EarnedMark { get; set; }
    }
}
