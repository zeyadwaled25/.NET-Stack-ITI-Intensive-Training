using System.Data.Common;
using System.Numerics;

namespace Day03
{

    internal class Program
    {
        //enum Days
        //{
        //    Saturday,
        //    Sunday,
        //    Monday = 3,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday = 3
        //}

        //enum OrderStatus
        //{
        //    Pending = 20,
        //    Approved,
        //    Rejected = 3
        //}

        //enum Grade
        //{
        //    Excellent = 1,
        //    VeryGood,
        //    Good,
        //    Fail
        //}

        static void Main(string[] args)
        {

            #region Enum

            //Days today = Days.Monday;

            //Console.WriteLine($"Today is : {today}");

            //OrderStatus status = OrderStatus.Approved;


            //Console.WriteLine($"Order staus : {status}");
            //Console.WriteLine($"Status Label : {(int)status}");



            //Console.WriteLine("Enter Student grade : ");
            //Console.WriteLine("1) Excellent");
            //Console.WriteLine("2) Very Good");
            //Console.WriteLine("3) Good");
            //Console.WriteLine("4) Fail");

            //int choice = int.Parse(Console.ReadLine());

            //Grade studentGrade = (Grade)choice;

            //Console.WriteLine($"You Entered {studentGrade}");

            //switch(studentGrade)
            //{
            //    case Grade.Excellent:
            //        Console.WriteLine("You are a topper");
            //        break;
            //    case Grade.VeryGood:
            //        Console.WriteLine("You are a very good student");
            //        break;
            //    case Grade.Good:
            //        Console.WriteLine("You are a good student");
            //        break;
            //    case Grade.Fail:
            //        Console.WriteLine("You need to work hard");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Grade");
            //        break;
            //}




            #endregion


            #region Struct

            //Point p1 = new Point(0, 0);
            //Point p2 = new Point(3, 4);

            //Console.WriteLine($"Point 1 : {p1.x} , {p1.y}");
            //Console.WriteLine($"Point 2 : {p2.x} , {p2.y}");

            //double distance = p1.DistanceTo(p2);

            //Console.WriteLine($" Distance between point 1 and point 2 : {distance}");
            #endregion


            #region Class

            //Student student1 = new Student();

            //student1.Name = "Ali";
            //student1.Age = 22;

            //Student student2 = new Student();

            //student2.Name = "osama";
            //student2.Age = 23;

            //student1.DisplayInfo();
            //Console.WriteLine("-----------------");
            //student2.DisplayInfo();


            //Car car1 = new Car();

            //car1.brand = "Toyota";
            //car1.color = "Red";


            //Car car2 = new Car();
            //car2.brand = "Honda";
            //car2.color = "Blue";

            //car1.Drive();
            //car2.Drive();


            //Student student1 = new Student("Ahmed",25);
            //Console.WriteLine($"Name: {student1.name}, Age: {student1.age}");


            //Student student2 = new Student("Ahmed",24);
            //Console.WriteLine($"Name: {student2.name}, Age: {student2.age}");

            //Student student1 = new Student("Mostafa", 25);

            //Student student2 = new Student(student1);

            //Console.WriteLine($"Name : {student2.name} , Age {student2.age}");

            //Point p1;
            //p1.x = 10;
            //p1.y = 20;
            //Console.WriteLine($"Point 1 : {p1.x} , {p1.y}");


            #endregion


            #region Encapsulation

            //Person p1 = new Person();

            // Calling Setter methods --------------
            //p1.SetName("Ali");
            //p1.SetAge(25);


            // Calling Getter methods --------------
            //Console.WriteLine($"Name : {p1.GetName()} , Age : {p1.GetAge()}");


            // Using Full Property --------------------
            //Product p1 = new Product();
            //p1.ProductName = "Laptop";
            //p1.Price = 1500;

            //Console.WriteLine($"Product Name : {p1.ProductName} , Price : {p1.Price}");




            // Using Automatic Property --------------------
            //Car c2 = new Car("BMW", 2022);
            //Console.WriteLine($"Model {c2.Brand} , {c2.ModelYear}");


            #endregion


        }
    }
}
