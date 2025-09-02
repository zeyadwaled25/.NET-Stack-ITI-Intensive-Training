namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("PH1");
            phone.TurnOn();
            phone.CallFeature();

            Console.WriteLine();

            SmartPhone smartPhone = new SmartPhone("SP1");
            smartPhone.TurnOn();
            smartPhone.MakeCall("01012345678");
            smartPhone.TakePhoto();

            Console.WriteLine();

            Tablet tablet = new Tablet("TB1");
            tablet.TurnOn();
            tablet.Browse();
        }
    }
}
