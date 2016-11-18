using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sandbox(); // a place to play around in....
            EvaluationGroup quizzes = new EvaluationGroup();
            quizzes.Name = "Quizzes";
            quizzes.Weight = 20;

            for (int count = 1; count <= 4; count++)
            {
                quizzes.AddEvaluationItem(PromptForComponent());
            }

        }

        public static EvaluationComponent PromptForComponent()
        {
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();
            Console.Write("Enter a weight: ");
            int weight;
            while (!int.TryParse(Console.ReadLine(), out weight))
                Console.Write("\tTry again (a whole number): ");

            var item = new EvaluationComponent(name, weight);

            Console.Write("Enter possible marks (or 0 to stop)");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
                Console.Write("\tTry again: ");
            if(number > 0)
            {
                item.PossibleMarks = number;
                Console.Write("Enter earned mark: ");
                double earned;
                while (!double.TryParse(Console.ReadLine(), out earned))
                    Console.Write("\tTry again: ");
                item.EarnedMark = earned;
            }

            return item;
        }

        public static void Sandbox()
        {
            EvaluationComponent quiz1 = new EvaluationComponent("Quiz 1", 5);
            quiz1.PossibleMarks = 16;
            quiz1.EarnedMark = 8;
            Display(quiz1);
        }

        public static void Display(EvaluationComponent item)
        {
            string message = $"{item.Name} is worth {item.Weight}% and I got {item.Mark}%, which is {item.WeightedMark}% of my final grade.";
            Console.WriteLine(message);
        }
    }
}
