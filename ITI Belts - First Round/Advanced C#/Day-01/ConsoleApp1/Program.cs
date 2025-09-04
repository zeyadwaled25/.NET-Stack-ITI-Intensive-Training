namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student("Zeyad", 20),
                new Student("Waled", 22),
                new Student("Ebrahim", null)
            };

            students[0].AddScores(85, 90, 95);
            students[1].AddScores(70, 65, 80);
            students[2].AddScores(75, 80, 80);

            foreach (var student in students)
            {
                var studentInfo = new
                {
                    student.Name,
                    student.Age,
                    AverageScore = student.GetAverageScore()
                };

                Console.WriteLine($"Name: {studentInfo.Name}, Age: {studentInfo.Age}, Average Score: {studentInfo.AverageScore}");
            }
        }
    }
}
