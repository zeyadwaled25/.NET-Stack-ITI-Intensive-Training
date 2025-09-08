
namespace Day03Advanced
{
    internal class Program
    {
        static int Factorial(int n)
        {
            if (n <= 1) 
                return 1;
            return n * Factorial(n - 1);
        }


        static bool SearchFamily(Person person, string name)
        {
            if (person.Name == name)
                return true;

            foreach (var child in person.Children)
            {
                if (SearchFamily(child, name))
                    return true;


            }
            return false;
        }


        static int Fibonacci(int n)
        {
            if(n==0)
                return 0;
            if (n == 1)
                return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int SumOfDigits(int n)
        {
            if (n == 0)
                return 0;
            return n % 10 + SumOfDigits(n / 10);
        }

        static void PrintMessage(string message, string sender = "Unknown" , string reciever = "Everyone")
        {
            Console.WriteLine($"Message : {message}");
            Console.WriteLine($"Sender : {sender}");
            Console.WriteLine($"Reciever : {reciever}");
        }


        static void DisplayInfo(string name , int age , double salary = 2000)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary}");
        }
        static void Main(string[] args)
        {

            #region Recursion

            //Console.Write("Enter any number: ");

            //int number =int.Parse(Console.ReadLine());

            //int result = Factorial(number);
            //Console.WriteLine($"Factorial of {number} is {result}");


            //Person grandParent = new Person() { Name = "Ahmed" };
            //Person parent1 = new Person() { Name = "Mohamed" };
            //Person parent2 = new Person() { Name = "Sara" };
            //Person child1 = new Person() { Name = "Ali" };

            //parent1.Children.Add(child1);
            //grandParent.Children.Add(parent1);
            //grandParent.Children.Add(parent2);

            //Console.Write("Enter name to search: ");
            //string name = Console.ReadLine();
            //bool found = SearchFamily(grandParent, name);

            //if (found)
            //    Console.WriteLine($"{name} is found in the family.");
            //else
            //    Console.WriteLine($"{name} is not found in the family.");

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.Write($"{ Fibonacci(i) }  ");
            //}

            //Console.Write(SumOfDigits(1234));
            #endregion


            #region Optional vs Named Parameters

            //PrintMessage("Hello World");
            //Console.WriteLine();
            //PrintMessage("Hello World", "Ahmed");
            //Console.WriteLine();
            //PrintMessage("Hello World","Ahmed" ,"Ali");


            //DisplayInfo(age:30 ,name:"Ahmed",salary : 5000);
            //Console.WriteLine();
            //DisplayInfo("Ahmed", age: 30);
            //Console.WriteLine();
            //DisplayInfo(salary:6000,age:30,name:"osama");

            #endregion


            #region Extension Method



            //int x = 5;

            //Console.WriteLine(x.Square());


            //string name = "Mohamed";
            //string name2 = "ahmed";

            //Console.WriteLine(name.checkIfFirstUppercase());
            //Console.WriteLine(name2.checkIfFirstUppercase());


            //string str = "Hello iti Students";

            //Console.WriteLine(str.ToUpper());

            //string name = "Ali";

            //Console.WriteLine(name.checkIfFirstUppercase());





            #endregion


            #region Record 

            //PersonClass person1 = new PersonClass() { Name = "Ahmed", Price = 2000 };
            //PersonClass person2 = new PersonClass() { Name = "Ahmed", Price = 2000 };

            //Console.WriteLine(person1==person2);

            //PersonRecord p1 = new PersonRecord("Mohamed", 2001);
            //PersonRecord p2 = new PersonRecord("Mohamed", 2000);

            //Console.WriteLine(p1==p2);


            //Product p1 = new Product("Laptop", 5000);
            //Product p2 = p1 with { Price = 6000 };

            //Console.WriteLine(p1.Name +" "+ p1.Price );
            //Console.WriteLine(p2.Name + " " + p2.Price );

            //Console.WriteLine(p1 == p2);

            #endregion

        }
    }
}
