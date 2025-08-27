namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Draw();
            circle.Move(10, 20);
            circle.Resize(1.5);

            Console.WriteLine();

            // Rectangle object
            Rectangle rect = new Rectangle();
            rect.Draw();
            rect.Move(30, 40);
            rect.Resize(2.0);
        }
    }
}
