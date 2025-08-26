namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.Write("Enter Student Id: ");
            int id = int.Parse(Console.ReadLine());
            student.Id = id;

            Console.Write("Enter Student Full Name: ");
            string fullName = Console.ReadLine();
            student.FullName = fullName;

            Console.Write("Enter Student Grade: ");
            double grade = double.Parse(Console.ReadLine());
            student.Grade = grade;
            
            Console.WriteLine();
            Console.WriteLine("Student Info:");
            Console.WriteLine($"ID: {student.Id}");
            Console.WriteLine($"Full Name: {student.FullName}");
            Console.WriteLine($"Grade: {student.Grade}");

        }
    }
}
