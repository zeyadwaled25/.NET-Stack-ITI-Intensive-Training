using Day04.Interface;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Static VS Readonly Field

            //Console.WriteLine(MyClass.counter);
            //MyClass obj1 = new MyClass();
            //MyClass obj2 = new MyClass();
            //MyClass obj3 = new MyClass();
            //Console.WriteLine(MyClass.counter);

            //MyClass num1 = new MyClass(10);

            //num1 = 20;







            #endregion


            #region Access Modifiers

            // 1) Private
            // 2) private prtoected
            // 3) Protected
            // 4) Internal
            // 5) Protected Internal
            // 6) Public


            #endregion


            #region Inheritance

            //Single Inheritance
            //Student student1 = new Student("Ali",25,"CS");
            //student1.Study();
            //student1.Introduce();











            //Multilevel Inheritance

            //SportsCar car1 = new SportsCar("Porsche 911", 4, true);
            //car1.Start();
            //car1.Drive();
            //car1.Boost();



            //Hierarchical Inheritance

            //Dog d1 = new Dog("Buddy");
            //d1.Eat();
            //d1.Bark();

            //Cat c1 = new Cat("Sweety");
            //c1.Eat();
            //c1.Meow();


            #endregion


            #region Interface

            //Example1
            //MultiFunctionMachine machine1 = new MultiFunctionMachine();
            //machine1.Print();
            //machine1.Scan();





            //Example2
            //IShape[] shapes =
            //{
            //new Circle(5),
            //new Square(4),
            //new Rectangle(3, 6)
            //};

            //foreach (IShape shape in shapes)
            //{
            //    shape.Draw();
            //    Console.WriteLine("Area: " + shape.GetArea());
            //    Console.WriteLine("Perimeter: " + shape.GetPerimeter());
            //    Console.WriteLine("---------------------------");
            //}



            //Example3
            //ElectricCar car1 = new ElectricCar();
            //car1.Brand = "Tesla";
            //car1.Year = 2022;

            //car1.Start();
            //car1.Charge();
            //car1.Maintain();


            #endregion




        }
    }
}
