namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Zeyad");
            Console.WriteLine("Student 1 Info:");
            Console.WriteLine($"Name: {s1.Name}, Age: {s1.Age}");

            Student s2 = new Student("Waled", 20);
            Console.WriteLine("Student 2 Info:");
            Console.WriteLine($"Name: {s2.Name}, Age: {s2.Age}");
        }
    }
}
