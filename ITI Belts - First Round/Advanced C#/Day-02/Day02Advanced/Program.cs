namespace Day02Advanced
{
    internal class Program
    {
        static void Speak(Animal animal)
        {
            if (animal is Dog dog)
            {
                //Dog dog = (Dog)animal;
                dog.Bark();
            }
            else if (animal is Cat cat)
            {
                cat.Meow();
            }
            else
            {
                Console.WriteLine("Unknown animal");
            }
        }


        static void ChangeNumnber(ref int number)
        {
            number = 100;

        }


        static void ChangeArray(ref int[] numbers)
        {
            numbers = new int[] { 100, 200, 300 };
            numbers[0] = 99;

        }

        static double Calculator(double num1, double num2, char op)
        {
            double Add(double x, double y) => x + y;
            double Subtract(double x, double y) => x - y;
            double Multiply(double x, double y) => x * y;
            double Divide(double x, double y) => y == 0 ? 0 : x / y;

            switch (op)
            {
                case '+':
                    return Add(num1, num2);
                case '-':
                    return Subtract(num1, num2);
                case '*':
                    return Multiply(num1, num2);
                case '/':
                    return Divide(num1, num2);
                default:
                    return 0;
            }
        }


        static void SearchNumber(int[] numbers, int target, int minValue)
        {
            bool FindTarget()
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == target)
                        return true;
                }
                return false;
            }

            void FindGreater()
            {
                Console.WriteLine($"Values greater than {minValue}: ");
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > minValue)
                        Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();

            }

            int? FindFirstEven()
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                        return numbers[i];
                }
                return null;

            }

            if (FindTarget())
                Console.WriteLine($"{target} found in the array.");
            else
                Console.WriteLine($"{target} not found in the array.");


            FindGreater();


            int? firstEven = FindFirstEven();
            Console.WriteLine(firstEven ?? 0);




        }




        static void Main(string[] args)
        {


            #region Is ,As Keywords

            //object obj = true;


            //if(obj is string text)  //pattern matching
            //{
            //    //string text = (string)obj;
            //    Console.WriteLine(text.ToUpper());
            //}
            //else
            //{
            //    Console.WriteLine("Not a string");
            //}


            //as

            //object hiringDate = DateTime.Now;


            //string date = hiringDate as string;


            //Console.WriteLine(date);



            //Animal dog = new Dog();
            //Speak(dog);


            //Animal cat = new Cat();
            //Speak(cat);

            #endregion


            #region Pass by value , Reference


            //int x = 10;

            //ChangeNumnber(ref x);
            //Console.WriteLine(x);
            #endregion

            #region Local Functions

            //int[] numbers = { 1, 2, 3};
            //ChangeArray(ref numbers);
            ////Console.WriteLine(numbers[0]);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}



            //Console.WriteLine(Calculator(10,5,'+'));
            //Console.WriteLine(Calculator(10,5,'-'));
            //Console.WriteLine(Calculator(10,5,'*'));
            //Console.WriteLine(Calculator(10,5,'/'));





            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //SearchNumber(numbers, 11, 6);
            #endregion


            #region Collections
            //list

            //List<string> names = new List<string>();

            //names.Add("Mohamed");
            //names.Add("Ahmed");
            //names.Add("Sayed");
            //names.Add("Mohamed");
            //names.Remove("Sayed");
            //names.Insert(1, "Ali");

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //List<int> numbers = new List<int>() { 1, 2, 3, 4 };

            //numbers.Add(5);
            //numbers.AddRange(new int[] { 6, 7, 8, 9, 10 });
            //numbers.Remove(3);
            //numbers.RemoveAt(4);
            ////numbers.Insert(3, 99);

            //Console.WriteLine(numbers.Count);

            //Console.WriteLine(numbers[1]);

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //Dictionary

            //Dictionary<int, string> employees = new Dictionary<int, string>();
            //employees.Add(1, "Mohamed");
            ////employees.Add(2, "Ahmed");
            //employees.Add(2, "Ahmed");
            //employees.Add(3, "Sayed");
            //employees.Add(4, "Sayed");

            //foreach (var emp in employees)
            //{
            //    Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");
            //}


            //hashset

            //HashSet<string> Cities = new HashSet<string>();
            //Cities.Add("Cairo");
            //Cities.Add("Giza");
            //Cities.Add("Cairo");
            //Cities.Add("Alex");

            //foreach (var city in Cities)
            //{
            //    Console.WriteLine(city);
            //}

            //Queue

            //Queue<string> names = new Queue<string>();

            //names.Enqueue("Mohamed");
            //names.Enqueue("Ahmed");
            //names.Enqueue("Sayed");
            //names.Enqueue("Ali");
            //names.Dequeue();

            //Console.WriteLine(names.Peek());

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //Stack

            //Stack<string> books = new Stack<string>();
            //books.Push("C#");
            //books.Push("Java");
            //books.Push("Python");
            //books.Pop();


            ////Console.WriteLine(books.Peek());
            //foreach (var book in books)
            //{
            //    Console.WriteLine(book);
            //}



            #endregion





        }
    }
}
