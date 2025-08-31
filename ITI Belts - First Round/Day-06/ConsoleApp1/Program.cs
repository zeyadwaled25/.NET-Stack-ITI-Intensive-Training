namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            {
                Id = 1,
                FullName = "Khaled",
                Age = 20,
                major = "Computer Science",
                gpa = 3.8
            };
            Professor p1 = new Professor()
            {
                Id = 101,
                FullName = "Eng Zeyad",
                Age = 45,
                department = "Software Engineering",
                salary = 15000
            };

            // Display Info
            s1.DisplayInfo();
            p1.DisplayInfo();
            Console.WriteLine();

            s1.RegisterCourse("OOP");
            s1.RegisterCourse("Machine Learning", 3);
            Console.WriteLine();

            p1.TeachCourse("Data Structures");
            Console.WriteLine();

            // Polymorphism
            Person person1 = s1;
            person1.DisplayInfo();
            Person person2 = p1;
            person2.DisplayInfo();
        }
    }
}
