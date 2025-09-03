namespace Day01Advanced
{
    internal class Program
    {

        static void ModifyyRef(ref int number)
        {
            number += 10;
        }


        static void CalculteSum(int x, int y, out int sum)
        {
            sum = x + y;

        }

        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void PrintNumbers(params int[] numbers)
        {
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void Sum(params int[] numbers)
        {
            int total = 0;
            foreach (var num in numbers)
            {
                total += num;
            }
            Console.WriteLine($"Sum = {total}");
        }


        static void Main(string[] args)
        {
            #region Nullable types

            //int? age = null;
            //Console.WriteLine(age);


            //if(age.HasValue)
            //{
            //    Console.WriteLine($"You are {age.Value} years old.");
            //}
            //else
            //{
            //    Console.WriteLine("Age is not provided.");
            //}


            //Employee emp1 = new Employee("Ahmed");
            //Employee emp2 = new Employee("Mohamed", 30, DateTime.Now);

            //Console.WriteLine($"Emplyee01 Name : {emp1.name} ,Age {emp1.age} , Hiring Date {emp1.hiringDate}");
            //Console.WriteLine($"Emplyee02 Name : {emp2.name} ,Age {emp2.age} , Hiring Date {emp2.hiringDate}");


            // Null Coalescing Operator (??)

            //int? age = null;
            //string name = null;
            //Console.WriteLine(name ?? "Hello");


            // Null Conditional  Operator (?.)

            //Employee employee = null;
            //Console.WriteLine(employee?.name);
            #endregion


            #region Var , Dyncamic , Object

            //var x = 5.5;

            //var y = (int)x;

            //Console.WriteLine(y);



            //dynamic x = 3;
            //Console.WriteLine(x+2);

            //x = "Hello";
            //Console.WriteLine(x.ToUpper());

            //Console.WriteLine(x.anyThing());

            //object obj = 5;
            //Console.WriteLine(obj);

            //obj = "Hello";
            //Console.WriteLine(((string)obj).ToUpper());


            #endregion


            #region ref , out 

            //int num = 5;
            //ModifyyRef(ref num);


            //int a = 10;
            //int b = 20;

            //Swap(ref a,ref b);
            //Console.WriteLine($"a = {a} , b = {b}");


            //Console.WriteLine(num);


            //int result;
            //CalculteSum(3, 4, out result);
            //Console.WriteLine(result);


            #endregion


            #region Params

            //PrintNumbers(1,2,3, 4, 5);
            //PrintNumbers(10, 20);

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 10, 20, 30 };
            //int[] arr3 = new int[5];

            //Sum(1,2,3,4,5);

            //Sum(10,20,30);
            //Sum();
            #endregion


            #region Anonymous types

            //var product = new { Name = "Laptop", Price = 1000};
            ////product.Name = "IPhone"; // Error
            //Console.WriteLine(product.Name);
            //Console.WriteLine(product.Price);


            //var cart = new List<object>();

            //var product1 = new { Name = "Laptop", Price = 1000 };

            //var product2 = new { Name = "IPhone", Price = 2000 };

            //cart.Add(product1);
            //cart.Add(product2);

            //foreach (var product in cart)
            //{
            //    Console.WriteLine(product);
            //}


            //var invoiceItems = new[]
            //{
            //    new { ProductName = "Laptop", Quantity = 2, Price = 1000 },
            //    new { ProductName = "IPhone", Quantity = 1, Price = 2000 },
            //    new { ProductName = "Tablet", Quantity = 3, Price = 500 }
            //};


            //int total = 0;

            //foreach (var item in invoiceItems)
            //{
            //    total += item.Quantity * item.Price;
            //    Console.WriteLine($"Product: {item.ProductName}, Quantity: {item.Quantity}, Price: {item.Price}");
            //}


            #endregion



            #region Generics

            //var calc = new Calculator();
            //Console.WriteLine(calc.Add<int>(2, 5,3));
            //Console.WriteLine(calc.Add<double>(2.5, 5.6,3.7));
            //Console.WriteLine(calc.Add<string>("Hello ", "ITI " , "Students"));


            //var intBox = new Box<int>(5);
            //intBox.Show();
            //var strBox = new Box<string>("Hello");
            //strBox.Show();
            //var dbouleeBox = new Box<double>(5.5);
            //dbouleeBox.Show();
            //var dateBox = new Box<DateTime>(DateTime.Now);
            //dateBox.Show();



            //var grades = new SimpleStorage<int>(3);

            //grades.Add(90);
            //grades.Add(80);
            //grades.Add(70);

            //grades.PrintAll();


            //var names = new SimpleStorage<string>(2);

            //names.Add("Ahmed");
            //names.Add("Akmal");

            //names.PrintAll();


            //var bookLibrary = new Library<Book>(3);

            //bookLibrary.Add(new Book { Title = "C# programming " , Author = "Abdullah" });
            //bookLibrary.Add(new Book { Title = "Java programming ", Author = "Mohamed" });
            //bookLibrary.Add(new Book { Title = "C programming ", Author = "Ahmed" });


            //bookLibrary.ShowAll();

            //var magazineLibrary = new Library<Magazine>(2);
            //magazineLibrary.Add(new Magazine { Name = "Forbes", IssueNumber = 202 });
            //magazineLibrary.Add(new Magazine { Name = "Time", IssueNumber = 101 });

            //magazineLibrary.ShowAll();


            #endregion
        }


    }
}
