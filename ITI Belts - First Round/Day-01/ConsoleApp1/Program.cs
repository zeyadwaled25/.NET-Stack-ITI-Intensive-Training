using System.ComponentModel;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Write a program that allows the user to enter a number then print it.
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered: {number}");

            //Task 2 - Write program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            string str = "123abc";
            try
            {
                int result = Convert.ToInt32(str);
                Console.WriteLine($"Converted number: {result}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); // This will throw the FormatException error
            }

            //Task 3 - Write program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            float a = 5.6f;
            float b = 4.4f;
            float sum = a + b;
            Console.WriteLine($"Sum: {sum}"); // This will work fine and print the sum

            //Task 4 - Write program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int x = 10;
            int y = x;
            y = 20;
            Console.WriteLine($"x: {x}, y: {y}"); // x will remain 10, y will be 20

            //Task 5 - Write program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            string[] arr1 = { "Hello", "World" };
            string[] arr2 = arr1;
            arr2[0] = "Hi";
            Console.WriteLine($"arr1[0]: {arr1[0]}, arr2[0]: {arr2[0]}"); // Both arr1[0] and arr2[0] will be "Hi"

            //Task 6 - Write program that take two string variables and print them as one variable 
            string str1 = "Hello, ";
            string str2 = "World!";
            string combined = str1 + str2;
            Console.WriteLine(combined); // This will print "Hello, World!"

            //Task 7
            int d;
            d = Convert.ToInt32(!(30 < 20));
            Console.WriteLine(d); // This will print 1 because is true

            //Task 8
            Console.WriteLine(13 / 2 + " " + 13 % 2); // This will print "6 1"

            //Task 9 
            int num = 1, z = 5;

            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z); // This will print "7 7"
            else
                Console.WriteLine(--num + z-- + " " + --z);
        }
    }
}
