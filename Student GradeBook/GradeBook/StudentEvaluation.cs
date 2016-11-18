namespace GradeBook
{
    /// <summary>
    /// A StudentEvaluation is a complete set of evaluation items used to generate the final mark for a given course for a single student.
    /// </summary>
    public class StudentEvaluation
    {
        public StudentEvaluation(string courseNumber, string courseName)
        {
            CourseNumber = courseNumber;
            CourseName = courseName;
        }

        public string CourseNumber { get; private set; }
        public string CourseName { get; private set; }
        public EvaluationGroup[] Groups { get; set; }
    }
}
