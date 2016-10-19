namespace EnumAndComposition
{
    public class QuebecLetterGrade
    {
        public LetterGrade Grade { get; private set; }

        public QuebecLetterGrade(LetterGrade grade)
        {
            Grade = grade;
        }

        public override string ToString()
        {
            string description;
            switch(Grade)
            {
                case LetterGrade.A:
                    description = "A - 80-100% - Greatly Above Standards";
                    break;
                case LetterGrade.B:
                    description = "B - 70-79% - Above Standards";
                    break;
                case LetterGrade.C:
                    description = "C - 60-69% - At Government Standards";
                    break;
                case LetterGrade.D:
                    description = "D - 50-60% - Lower Standards";
                    break;
                case LetterGrade.F:
                    description = "F - 0-49% - Failure";
                    break;
                default:
                    description = "Invalid Letter Grade";
                    break;
            }
            return description;
        }
    }
}
