namespace AppStar
{
    public class MarathonRunner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int RunnerNumber { get; set; }
        public double MinutesToComplete { get; set; }

        public override string ToString()
        {
            return $"({RunnerNumber}) {FirstName} {LastName} completed in {MinutesToComplete}";
        }
    }
}