using System.Text;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region String VS StringBuilder

            //String is Reference Type but acts like a Value Type
            //String is Immutable

            //string name = "Mostafa";
            //Console.WriteLine(name.GetHashCode());
            //name = "Ahmed";
            //Console.WriteLine(name.GetHashCode());
            //Console.WriteLine(name);




            //String is an array of characters
            //string name = "Osama";
            //Console.WriteLine(name[0]);
            //Console.WriteLine(name[1]);


            //StringBuilder is a Reference Type and Mutable
            //StringBuilder is used for performance when dealing with a lot of string manipulations


            //StringBuilder email = new StringBuilder();
            //email.AppendLine("Hello Mostafa,");
            //Console.WriteLine(email.GetHashCode());
            //email.AppendLine("Thank you for your order!");
            //Console.WriteLine(email.GetHashCode());
            //email.AppendLine("Order Details:");
            //Console.WriteLine(email.GetHashCode());
            //email.AppendLine(" - Item: Laptop");
            //email.AppendLine(" - Price: 1200");
            //email.AppendLine();
            //email.AppendLine("Best regards,");
            //email.AppendLine("Your Store");
            //Console.WriteLine(email.ToString());



            //StringBuilder sb = new StringBuilder("Hello World");
            //sb.Insert(6, "C# ");

            //sb.Replace("World", "Developers");
            //Console.WriteLine(sb.ToString());



            //StringBuilder sb = new StringBuilder("123456789");
            //sb.Remove(3, 3);
            //Console.WriteLine(sb.ToString());

            #endregion


            #region String Formating
            //String Concatination
            //String FirstName = "Ahmed";
            //String LastName = "Ali";

            //Console.WriteLine("Full Name: " + FirstName + " " + LastName);

            //String.Format
            //String FirstName = "Ahmed";
            //int age = 30;

            //Console.WriteLine("Name: {0}, Age: {1}", FirstName, age);

            //String Interpolation
            //string FirstName = "Ahmed";
            //int age = 30;

            //Console.WriteLine($"Name: {FirstName}, Age: {age}");


            //double salary = 5000.552226;
            //Console.WriteLine($"Price: {salary:F2}");
            //Console.WriteLine($"Price: {salary:C}");
            #endregion


            #region Conditional Statements

            //if, else if, else

            //Grade
            //Console.WriteLine("Enter your grade : ");
            //char grade = char.Parse(Console.ReadLine());

            //if(grade == 'A')
            //{
            //    Console.WriteLine("Excellent");
            //}
            //else if (grade == 'B')
            //{
            //    Console.WriteLine("Very Good");
            //}
            //else if (grade == 'C')
            //{
            //    Console.WriteLine("Good");
            //}
            //else if (grade == 'D')
            //{
            //    Console.WriteLine("Pass");
            //}
            //else if (grade == 'F')
            //{
            //    Console.WriteLine("Fail");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Grade");
            //}

            //Username , Password
            //Console.WriteLine("enter you username");
            //string username = Console.ReadLine();
            //Console.WriteLine("enter you password");
            //int password = int.Parse(Console.ReadLine());

            //if (username == "admin" && password == 1234)
            //{
            //    Console.WriteLine("Welcome Admin");
            //}
            //else if (username == "user" && password == 5678)
            //{
            //    Console.WriteLine("Welcome User");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Username or Password");
            //}


            //-----------------------------------
            //switch statement

            //Console.WriteLine("Press (1) for => Tea");
            //Console.WriteLine("Press (2) for => Coffee");
            //Console.WriteLine("Press (3) for => Juice");

            //int choice = int.Parse(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("You chose Tea");
            //        break;
            //    case 2:
            //        Console.WriteLine("You chose Coffee");
            //        break;
            //    case 3:
            //        Console.WriteLine("You chose Juice");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid choice");
            //        break;
            //}



            //string day = "Saturday";

            //switch (day)
            //{
            //    case "Friday":
            //    case "Saturday":
            //        Console.WriteLine("Weekend!");
            //        break;
            //    default:
            //        Console.WriteLine("Working day!");
            //        break;
            //}




            //Console.Write("Enter grade (A, B, C, D, F): ");
            //string grade = Console.ReadLine();

            //string result;

            //switch (grade)
            //{
            //    case "A":
            //        result = "Excellent!";
            //        break;
            //    case "B":
            //        result = "Very Good!";
            //        break;
            //    case "C":
            //        result = "Good!";
            //        break;
            //    case "D":
            //        result = "Pass!";
            //        break;
            //    case "F":
            //        result = "Fail!";
            //        break;
            //    default:
            //        result = "Invalid grade!";
            //        break;
            //}

            //Console.WriteLine(result);


            //New Switch Expression (C# 8.0 and later)
            //Console.Write("Enter grade (A, B, C, D, F): ");
            //String grade = Console.ReadLine();
            //String result = grade switch
            //{
            //    "A" => "Excellent!",
            //    "B" => "Very Good!",
            //    "C" => "Good!",
            //    "D" => "Pass!",
            //    "F" => "Fail!",
            //    _ => "Invalid grade!"
            //};






            #endregion


            #region Loops


            //while

            //while (condition)
            //{
            //    // body
            //}


            //int i = 1;
            //while (i <= 100)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine(i);




            //int sum = 0;

            //while (sum <= 50)
            //{
            //    Console.Write("Enter a number: ");
            //    int num = int.Parse(Console.ReadLine());

            //    sum += num;
            //}

            //Console.WriteLine("Final Sum = " + sum);



            //int i = 0;
            //while (true)
            //{
            //    i++;
            //    if (i % 3 == 0) continue;
            //    if (i > 10) break;
            //    Console.WriteLine(i);
            //}


            //do while ---------------------------

            //do
            //{
            //    // body
            //}
            //while (condition);



            //string choice;
            //do
            //{
            //    Console.WriteLine("1) Tea");
            //    Console.WriteLine("2) Coffee");
            //    Console.WriteLine("0) Exit");
            //    Console.Write("Choose: ");

            //    choice = Console.ReadLine();

            //    if (choice == "1") Console.WriteLine("Tea selected");
            //    else if (choice == "2") Console.WriteLine("Coffee selected");
            //}
            //while (choice != "0");




            //string pass, confirm;
            //do
            //{
            //    Console.Write("Password: ");
            //    pass = Console.ReadLine();
            //    Console.Write("Confirm: ");
            //    confirm = Console.ReadLine();
            //    if (pass != confirm)
            //        Console.WriteLine("Not matching, try again.");
            //}
            //while (pass != confirm);
            //Console.WriteLine("Saved");



            //for loop ---------------------------

            //for (initializer; condition; iterator)
            //{
            //    // body
            //}



            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.Write("Enter Start number : ");
            //int start = int.Parse(Console.ReadLine());
            //Console.Write("Enter End number : ");
            //int end = int.Parse(Console.ReadLine());

            //for (int i = start; i <= end; i++)
            //{
            //    if (i % 2 == 0)  continue;
            //    Console.WriteLine(i);
            //}



            //Nested Loops ---------------------------

            //for (int i = 1; i <= 12; i++)
            //{
            //    for (int j = 1; j <= 12; j++)
            //    {
            //        Console.Write($"  {i * j}\t");
            //    }
            //    Console.WriteLine();
            //}

            //foreach loop ---------------------------

            //foreach (var item in collection)
            //{
            //    // body
            //}

            //string name = "AbdElrahman";
            //foreach (char c in name)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion


            #region Array



            //Array is a data structure that stores a fixed sequence of elements of the same type.
            //Array is a reference type
            //each element can be accessed by its index
            //Array is zero-based , meaning the first element is at index 0

            //int[] numbers = new int[5];


            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };


            //int[] numbers = { 1, 2, 3, 4, 5 };  // Sugar Sytax



            //Console.WriteLine("Enter size of elements : ");
            //int size = int.Parse(Console.ReadLine());
            //int[] grades = new int[size];

            //grades[0] = 90;
            //grades[1] = 85;
            //grades[2] = 70;
            //grades[3] = 95;
            //grades[4] = 100;



            //for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Enter grade {i + 1}: ");
            //        grades[i] = int.Parse(Console.ReadLine());
            //    }


            //foreach (var grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}   

            ////print grades using for loop
            //for(int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Grade {i + 1}: {grades[i]}");
            //}



            //Average of grades
            //int[] grades = { 90, 85, 70, 95, 99 };
            //int sum = 0;
            //double average = 0.0;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    sum += grades[i];
            //    average = (double)sum / grades.Length;
            //}

            //Console.WriteLine("Average = " + average);




            //int[] grades = { 90, 85, 70, 95, 100 };

            //int max = grades[0];
            //int min = grades[0];

            //for (int i = 1; i < grades.Length; i++)
            //{
            //    if (grades[i] > max)
            //        max = grades[i];

            //    if (grades[i] < min)
            //        min = grades[i];
            //}

            //Console.WriteLine("Max = " + max);
            //Console.WriteLine("Min = " + min);





            //2D arrays -------------------------------

            //10   20   30   40
            //50   60   70   80
            //90   100  110  120


            //int[,] matrix = new int[3, 4];  //3 rows and 4 columns

            //matrix[0, 0] = 10;
            //matrix[0, 1] = 20;
            //matrix[0, 2] = 30;



            //int[,] numbers =
            //{
            //    {1, 2, 3},
            //    {4, 5, 6},
            //    {7, 8, 9}
            //};
            //Console.WriteLine(numbers[0, 0]);
            //Console.WriteLine(numbers[1, 2]);





            //int[,] numbers =
            //{
            //    {1, 2, 3},
            //    {4, 5, 6},
            //    {7, 8, 9}
            //};
            //for (int row = 0; row < 3; row++)
            //{
            //    for (int col = 0; col < 3; col++)
            //    {
            //        Console.Write(numbers[row, col] + "\t");
            //    }
            //    Console.WriteLine();
            //}




            //int[,] grades = new int[3, 4]; // 3 Students, 4 Subjects

            //// Input from user
            //for (int student = 0; student < 3; student++)
            //{
            //    Console.WriteLine($"Enter grades for Student {student + 1}:");
            //    for (int subject = 0; subject < 4; subject++)
            //    {
            //        Console.Write($"Subject {subject + 1}: ");
            //        grades[student, subject] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine();

            //// Calculate average
            //for (int student = 0; student < 3; student++)
            //{
            //    int total = 0;
            //    for (int subject = 0; subject < 4; subject++)
            //    {
            //        total += grades[student, subject];
            //    }
            //    double average = total / 4.0;
            //    Console.WriteLine($"Student {student + 1} Average: {average}");
            //}





            #endregion



            #region Shallow copy VS Deep copy

            //Shallow copy

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = arr1;

            //arr2[0] = 100; // This will change arr1 as well

            //Console.WriteLine(arr1[0]);



            // Deep copy
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = new int[5];

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr2[i] = arr1[i]; // Copy each element
            //}
            //arr2[0] = 100; // This will not change arr1

            //Console.WriteLine(arr1[0]);




            // Deep copy using Clone method
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = (int[])arr1.Clone();

            //arr2[0] = 100; // This will not change arr1
            //Console.WriteLine(arr1[0]);
            #endregion





        }
    }
}
