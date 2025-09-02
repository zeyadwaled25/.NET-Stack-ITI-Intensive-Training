using Day06.Partial_Class;
using Day06.Sealed_Class;
using Day06.Static_Class;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Animal dog = new Dog();
            //dog.Speak();

            //Animal cat = new Cat();
            //cat.Speak();


            //Vehicle car = new Car("Toyota", "Camry", 2020);
            //car.StartEngine();
            //car.Drive();
            //car.StopEngine();


            //Vehicle bus = new Bus("Volvo", "7700", 2018);
            //bus.StartEngine();
            //bus.Drive();
            //bus.StopEngine();



            //BankAccount account = new SavingAccount("1",5000);
            //account.Deposit(1000);
            //account.Withdraw(6000);
            //account.Withdraw(5800);
            //account.DisplayBalance();


            //BankAccount account1 = new CurrentAccount("2", 2000);
            //account1.Deposit(500);
            //account1.Withdraw(2500);
            //account1.DisplayBalance();


            //double result1 = TemperatureConverter.CelsiusToFahrenheit(25);

            //double result2 =  TemperatureConverter.FahrenheitToCelsius(77);

            //Console.WriteLine($"25 degree Celsius is equal to {result1} degree Fahrenheit");
            //Console.WriteLine($"77 degree Fahrenheit is equal to {result2} degree Celsius");


            Employee emp = new Employee();

            emp.Name = "John Doe";
            emp.Age = 30;
            emp.DisplayInfo();




        }
    }
}
