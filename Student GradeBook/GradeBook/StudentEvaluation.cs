namespace GradeBook
{
    /// <summary>
    /// A StudentEvaluation is a complete set of evaluation items used to generate the final mark for a given course for a single student.
    /// </summary>
    public class StudentEvaluation
    {
        public string CourseNumber { get; set; }
        public string CourseName { get; set; }
        public EvaluationGroup[] Groups { get; set; }
    }
}
