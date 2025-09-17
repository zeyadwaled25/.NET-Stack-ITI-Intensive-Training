namespace ConsoleApp3
{
    internal class Program
    {
        static void SendConfirmation(object sender, EventArgs e)
        {
            Console.WriteLine("Order placed successfully!");
        }
        static void Main(string[] args)
        {
            Order order = new Order();
            order.OrderPlaced += SendConfirmation;

            order.PlaceOrder();
        }
    }
}
