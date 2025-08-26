namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
                Console.Write("Enter Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 % 3 == 0 && num1 % 4 == 0)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            #endregion

            #region Task 2 - Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
                Console.Write("Enter Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 < 0)
                {
                    Console.WriteLine("Negative");
                }
                else
                {
                    Console.WriteLine("Positive");
                }
            #endregion

            #region Task 3 - Write a program that takes 3 integers from the user then prints the max element and the min element.
                int maxNum = 0;
                int minNum = 0;
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write($"Enter Number {i}: ");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    if (num3 > maxNum)
                    {
                        maxNum = num3;
                    }
                    else
                    {
                        minNum = num3;
                    }
                }
                Console.WriteLine("Max Number: " + maxNum);
                Console.WriteLine("Min Number: " + minNum);
            #endregion

            #region Task 4 - Write a program that allows the user to insert an integer number then check If a number is even or odd.
                Console.Write("Enter Number: ");
                int num4 = Convert.ToInt32(Console.ReadLine());
                if (num4 % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            #endregion

            #region Task 5 - Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
                Console.Write("Enter Character: ");
                char ch = Convert.ToChar(Console.ReadLine());
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' }
                ;
                for (int i = 0; i < vowels.Length; i++)
                {
                    if (ch == vowels[i])
                    {
                        Console.WriteLine("Vowel");
                        break;
                    }
                    else if (i == vowels.Length - 1)
                    {
                        Console.WriteLine("Consonant");
                    }
                }
            #endregion

            #region Task 6 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
                Console.Write("Enter Iteration Number: ");
                int num5 = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= num5; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            #endregion

            #region Task 7 - Write a program that allows the user to insert an integer then print a multiplication table up to 12.
                Console.Write("Enter Multiply Number: ");
                int num6 = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= 12; i++)
                {
                    Console.Write($"{num6 * i} ");
                }
                Console.WriteLine();
            #endregion

            #region Task 8 - Write a program that allows to user to insert number then print all even numbers between 1 to this number.
                Console.Write("Enter Each Number: ");
                int num7 = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= num7; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            #endregion

            #region Task 9 - Write a program that takes two integers then prints the power.
                Console.Write("Enter Number 1: ");
                int num8 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Number 2: ");
                int num9 = Convert.ToInt32(Console.ReadLine());
                int finalNum = 1;
                for (int i = 1; i <= num9; i++)
                {
                    finalNum *= num8;
                }
                Console.WriteLine($"{num8}^{num9}: {finalNum}");
            #endregion

            #region Task 10 - Write a program to enter marks of five subjects and calculate total, average and percentage.
                int totalMarks = 0;
                Console.WriteLine("###Enter Marks Of Subjects###");
                for (int i = 1; i <= 5; i++)
                {   
                    Console.WriteLine($"Enter mark of subject {i}: ");
                    int num10 = Convert.ToInt32(Console.ReadLine());
                    totalMarks += num10;
                }
                double average = totalMarks / 5;
                double percentage = (totalMarks / 500) * 100;

                Console.WriteLine("Total Marks = " + totalMarks);
                Console.WriteLine("Average Marks = " + average);
                Console.WriteLine("Percentage = " + percentage);
            #endregion

            #region Task 11 - Write a program to enter marks of five subjects and calculate total, average and percentage.
                Console.Write("Enter first number: ");
                double num11 = double.Parse(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, /): ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num12 = double.Parse(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = num11 + num12;
                        break;
                    case '-':
                        result = num11 - num12;
                        break;
                    case '*':
                        result = num11 * num12;
                        break;
                    case '/':
                        if (num12 != 0)
                            result = num11 / num12;
                        else
                            Console.WriteLine("Error: Division by zero!");
                        break;
                    default:
                        Console.WriteLine("Invalid operator");
                        break;
                }
                Console.WriteLine("Result = " + result);
            #endregion

            #region Task 12 - Write a program that takes elements of an array from the user and calculates the sum of only even numbers.
                Console.Write("Enter length of array: ");
                int num13 = int.Parse(Console.ReadLine());

                int[] arr = new int[num13];
                Console.WriteLine("Enter elements of array: ");
                for (int i = 0; i < num13; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int evenSum = 0;
                for (int i = 0; i < num13; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        evenSum += arr[i];
                    }
                }

                Console.WriteLine("Sum of even numbers = " + evenSum);
            #endregion
        }
    }
}
