using System.Net.Security;

namespace Day05Advanced
{
    delegate void Notify(string message);

    delegate int Operation(int a, int b);

    //delegate void LogHandler(string message);

    delegate void Great();

    delegate void OrderFood(string food);

    delegate int Square(int x);

    delegate T MyOperation<T>(T a, T b);


    internal class Program
    {
        //static void ShowMessage(string message)
        //{
        //    Console.WriteLine("ShowMessage : "+message);
        //}
        ////---------------------------------------------

        //static int Add(int a, int b) => a + b;
        //static int Multiply(int a, int b) => a * b;

        ////---------------------------------------------

        //public static void LogCosole(string message)
        //{
        //    Console.WriteLine("Console : " + message);
        //}
        ////---------------------------------------------

        //static void SayHello()
        //{
        //    Console.WriteLine("Hello ITI Students");
        //}

        //static void SayBye()
        //{
        //    Console.WriteLine("Bye ITI Students");
        //}




        //public static void LogUpper(string message)
        //{
        //    Console.WriteLine("Upper : " + message.ToUpper());
        //}
        ////---------------------------------------------


        //static void CookFood(string food)
        //{
        //    Console.WriteLine("Cooking " + food);
        //}


        //static void ServeFood(string food)
        //{
        //    Console.WriteLine("Serving " + food);
        //}  
        
        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        
        static void SayHello()
        {
            Console.WriteLine("Hello ITI Students");
        }

        //----------------------------------------------
        static void PrintTimes(string text, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }

        //----------------------------------------------

        static void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

        static void Alert(string message)
        {
            Console.WriteLine($"Alert: {message}");
        }

        //----------------------------------------------

        static string GetMessage() => "Hello from Func Delegate";

        //----------------------------------------------

        static string MakeTitle(string name) => $"Eng : {name}";
        static int Add(int a, int b) => a + b;
        //----------------------------------------------

        static bool IsEven(int number) => number % 2 == 0;

        //----------------------------------------------

        static bool IsLongName(string name) => name.Length > 5;
        //----------------------------------------------

        static bool IsPositive(int number) => number > 0;
        static void Main(string[] args)
        {
            #region UserDefined Delegates

            //Delegate with void method

            //Notify n1 = new Notify(ShowMessage);
            //n1("Hello World");

            //Notify n2 = ShowMessage;
            //n2("Hello ITI Students");


            //Delegate with return type method
            //Operation op1 = new Operation(Add);
            //int result1 = op1(10, 20);
            //Console.WriteLine(result1);

            //Operation op2 = Multiply;

            //int result2 = op2(10, 20);
            //Console.WriteLine(result2);

            //Using Delegate as Parameter

            //Calculator.Perform(Add, 10, 20);
            //Calculator.Perform(Multiply, 5, 5);



            //Multicast Delegate

            //Notify notify = LogCosole;

            //notify += LogUpper;

            //notify("Hello Mohamed");
            ////notify("Hello ITI Students");
            //notify -= LogCosole;
            //notify("Hello Ahmed");


            //Great great = SayHello;
            //great += SayBye;
            //great();


            //Delegate with parameters 
            //OrderFood order = CookFood;
            //order += ServeFood;
            //order("Pizza");
            //order-= ServeFood;
            //order("Pasta");


            //Anonymous Methods

            //Great g = delegate
            //{
            //    Console.WriteLine("Hello from Anonymous Method");
            //};
            //g();

            // Delegate with Lambda Expression

            //Square sq = num => num * num;
            //Console.WriteLine(sq(5));


            // Generic Delegate

            //MyOperation<int> addInt = (a, b) => a + b;
            //Console.WriteLine($"Add two int : {addInt(2,5)}");

            //MyOperation<double> addDouble = (a, b) => a + b;
            //Console.WriteLine($"Add two double : {addDouble(2.6, 5.5)}");

            //MyOperation<string> concatString = (a, b) => a + b;
            //Console.WriteLine($"Concat two string : {concatString("Hello ", "World")}");
            #endregion


            #region Built-in Delegates

            // Action Delegate
            //Action a = SayHello;
            //a();

            //Action with parameters
            //Action<string, int> print = PrintTimes;
            //print("ITI", 3);


            //Action with multiCast
            //Action<string> action = Log;
            //action += Alert;
            //action("This is a message");
            //action-= Alert;
            //action("This is another message");

            // Func Delegate

            //Func<string> func = GetMessage;
            //string msg = func();
            //Console.WriteLine(msg);

            //Func<int, int, int> funcAdd = Add;
            //Console.WriteLine(funcAdd(5,6));

            //Func<string, string> funcTitle = MakeTitle;
            //string name1 = funcTitle("Mohamed");

            //string name2 = funcTitle("Abdullah");


            //Console.WriteLine(name1);
            //Console.WriteLine(name2);

            // Predicate Delegate

            //Predicate<int> isEven = IsEven;

            //Console.WriteLine(isEven(4));
            //Console.WriteLine(isEven(7));


            //Predicate<string> isLongName = IsLongName;
            //Console.WriteLine(isLongName("Ali"));
            //Console.WriteLine(isLongName("Mohamed"));

            //Predicate<int> isPositive = IsPositive;

            //int[] numbers = { -10, 0, 5, 8, -3, 12 };

            //List<int> positiveNumbers = new List<int>();

            //foreach (var number in numbers)
            //{
            //    if (isPositive(number))
            //    {
            //        positiveNumbers.Add(number);
            //    }
            //}

            //Console.WriteLine("Positive numbers : ");

            //foreach (var num in positiveNumbers)
            //{
            //    Console.WriteLine(num);
            //}


            #endregion

        }
    }
}
