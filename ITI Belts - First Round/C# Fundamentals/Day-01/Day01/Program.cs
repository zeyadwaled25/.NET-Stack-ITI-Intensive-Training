namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Types Of Errors
            //Syntax Error:
            //Console.WriteLine("Hello");

            //Logical Error:
            //int a = 5;
            //int b = 10;
            //int sum = a - b;
            //Console.WriteLine("Sum: " + sum); // This will print a wrong result due to logical error


            //Runtime Error:
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(numbers[5]);

            //warning 

            //int a = 10;


            #endregion


            #region DataTypes in memory

            //int a = 10; // 4 bytes in memory
            //double b = 20.5; // 8 bytes in memory
            //char c = 'A'; // 2 bytes in memory

            //string d = "Hello"; // Reference type, memory size depends on the length of the string


            //bool isTrue = true; // 1 byte in memory

            //decimal price = 19.99m; // 16 bytes in memory, used for financial calculations
            //float e = 10.5f; // 4 bytes in memory, single-precision floating-point number


            //var x = 123;
            //x = "Ahmed"


            //dynamic y = 10; // Dynamic type, can hold any type of data
            //y = "Ali"; // Now y holds a string
            //y = true;


            //object z = 10; // Object type, can hold any type of data
            //z = "Hello"; // Now z holds a string

            #endregion

            #region DataTypes Categories

            //value types
            //int x = 5;
            //int y = x;
            //y = 10;

            //Console.WriteLine(x);
            //Console.WriteLine(y);

            //Reference Types
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = arr1; //{ 1, 2, 3 };

            //arr2[0] = 90;

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);



            #endregion

            #region Casting

            //Implicit , Explicit , Parse  and Convert

            //implicit casting 
            //safe casting 
            //Automatically
            //int a = 10;
            //double b = a;

            //Console.WriteLine(b);

            //Expilict casting
            //unsafe casting
            //manual casting

            //double a = 20000000000;
            //int b = (int)a;

            //Console.WriteLine(b);


            //Parse Method

            //Console.WriteLine("Please enter any num : ");

            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("You entered: " + num);


            //Convert Method

            //Console.WriteLine("enter any number : ");
            //int input = Convert.ToInt32(Console.ReadLine());


            //try parse

            //bool isParsed = int.TryParse(Console.ReadLine(), out int result);

            //if (isParsed)
            //{
            //    Console.WriteLine("Parsed successfully: " + result);
            //}
            //else
            //{
            //    Console.WriteLine("Failed to parse input.");
            //}




            #endregion

            #region Operators

            //Unary operators

            //int x = 5;

            //Console.WriteLine(x++);
            //Console.WriteLine(x);
            //Console.WriteLine(++x);
            //Console.WriteLine(x--);
            //Console.WriteLine(x);


            //int y = 10;
            //Console.WriteLine(-y); // -10  


            //Binary operators

            //int a = 11;
            //int b = 5;

            //Console.WriteLine(a + b); // Addition → 15
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b); // Multiplication → 50
            //Console.WriteLine(a / b); // Division → 2
            //Console.WriteLine(a % b); // Modulus → 0 (remainder of division)



            //Arthimetic Operators

            //int c = 5;
            //c += 3; // c = c + 3 → 8
            //c -= 2; // c = c - 2 → 6
            //c *= 4; // c = c * 4 → 24
            //c /= 6; // c = c / 6 → 4
            //c %= 3; // c = c % 3 → 1


            //Relational Operators  (Comparison Operators)

            //int m = 5, n = 10;
            //Console.WriteLine(m == n); // false
            //Console.WriteLine(m != n); // true
            //Console.WriteLine(m > n);  // false
            //Console.WriteLine(m < n);  // true
            //Console.WriteLine(m >= 5); // true
            //Console.WriteLine(m <= 4); // false


            //Logical Operators
            //bool cond1 = true;
            //bool cond2 = false;

            //Console.WriteLine(cond1 && cond2); // false (AND)
            //Console.WriteLine(cond1 || cond2); // true (OR)
            //Console.WriteLine(!cond1);         // false (NOT)


            //Bitwise Operators
            //int p = 5;  // 0101 in binary
            //int q = 3;  // 0011 in binary

            //Console.WriteLine(p & q); // Bitwise AND → 0001 (1 in decimal)
            //Console.WriteLine(p | q); // Bitwise OR → 0111 (7 in decimal)

            //Ternary Operator

            //int age = 20;
            //string result = (age >= 18) ? "Adult" : "Minor";
            //Console.WriteLine(result);


            #endregion
        }
    }
}
