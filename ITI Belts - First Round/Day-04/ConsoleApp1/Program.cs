namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW", 50000, 1001);
            Car car2 = new Car("Toyota", 30000, 1002);
            Car car3 = new Car("Mercedes", 70000, 1003);

            car1.DisplayCar();
            car2.DisplayCar();
            car3.DisplayCar();

            Console.WriteLine($"\nTotal Cars Created: {Car.TotalCars}");
        }
    }
}
