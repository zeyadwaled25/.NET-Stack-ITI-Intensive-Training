namespace ConsoleApp4
{
    public delegate void Notifier();
    internal class Program
    {
        static void SendSMS() => Console.WriteLine("SMS sent");
        static void SendEmail() => Console.WriteLine("Email sent");
        static void ShowPopup() => Console.WriteLine("Popup notification shown");
        static void Main(string[] args)
        {
            Notifier notify = SendSMS;
            notify += SendEmail;
            notify += ShowPopup;

            notify();
        }
    }
}
