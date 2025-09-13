namespace ConsoleApp1
{
    internal class Program
    {
        static void StopPump()
        {
            Console.WriteLine("Pump stopped, tank is full!");
        }
        static void Main(string[] args)
        {
            WaterTank tank = new WaterTank();
            tank.TankFull += StopPump;
            tank.Fill(50);
            tank.Fill(50);
        }
    }
}
