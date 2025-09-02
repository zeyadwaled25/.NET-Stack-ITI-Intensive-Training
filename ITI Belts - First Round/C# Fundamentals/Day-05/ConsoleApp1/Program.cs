namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment payment1 = new CreditCardPayment(100.50, "USD", "1234-5678-9876-5432");
            Payment payment2 = new PayPalPayment(250.75, "EGY", "zeyad@gmail.com");

            payment1.ProcessPayment();
            payment2.ProcessPayment();
        }
    }
}
