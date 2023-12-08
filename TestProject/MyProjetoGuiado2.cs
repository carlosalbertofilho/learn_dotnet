using System.Xml.Schema;

namespace TestProject
{
    class MyProjetoGuiado2
    {
        public static void Run()
        {
            // initialize variables - graded assignments
            int currentAssignments = 5;

            // Student names
            var studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            var sophia = new int[] { 90, 86, 87, 98, 100 };
            var andrew = new int[] { 92, 89, 81, 96, 90 };
            var emma = new int[] { 90, 85, 87, 98, 68 };
            var logan = new int[] { 90, 95, 87, 88, 96 };

            var studantScores = new decimal[]
            {
                (decimal)sophia.Sum() / currentAssignments,
                (decimal)andrew.Sum() / currentAssignments,
                (decimal)emma.Sum() / currentAssignments,
                (decimal)logan.Sum() / currentAssignments
            };

            Console.WriteLine("Student\t\tGrade\n");

            foreach (
                var (student, score) in studentNames.Zip(
                    studantScores,
                    (student, score) => (student, score)
                )
            )
            {
                Console.WriteLine($"{student}:\t\t{score}\t{PrintScore(score)}");
            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadLine();
        }

        private static string PrintScore(decimal score)
        {
            if (score >= 97)
                return "A+";
            else if (score >= 93)
                return "A";
            else if (score >= 90)
                return "A-";
            else if (score >= 87)
                return "B+";
            else if (score >= 83)
                return "B";
            else if (score >= 80)
                return "B-";
            else if (score >= 77)
                return "C+";
            else if (score >= 73)
                return "C";
            else if (score >= 70)
                return "C-";
            else if (score >= 67)
                return "D+";
            else if (score >= 63)
                return "D";
            else if (score >= 60)
                return "D-";
            else
                return "F";
        }
    }
}
