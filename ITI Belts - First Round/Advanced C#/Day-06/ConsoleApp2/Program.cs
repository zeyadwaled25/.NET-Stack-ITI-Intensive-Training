namespace ConsoleApp2
{
    internal class Program
    {
        static void TurnOnLamp(int luxLevel)
        {
            Console.WriteLine($"Lamp turned on, lux: {luxLevel}");
        }
        static void LogLightChange(int luxLevel)
        {
            Console.WriteLine($"Light level changed to {luxLevel}");
        }
        static void Main(string[] args)
        {
            LightSensor sensor = new LightSensor();
            sensor.LightChanged += TurnOnLamp;
            sensor.LightChanged += LogLightChange;

            sensor.SetLightLevel(300);
        }
    }
}
