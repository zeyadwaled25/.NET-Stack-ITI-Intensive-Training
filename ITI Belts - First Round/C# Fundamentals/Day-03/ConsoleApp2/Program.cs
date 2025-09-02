namespace ConsoleApp2
{
    internal class Program
    {
        enum Operation
        {
            Deposit = 1,
            Withdraw = 2
        }
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            Console.Write("Enter Your Balance: ");
            decimal initialBalance = Convert.ToDecimal(Console.ReadLine());
            bankAccount.Balance = initialBalance;

            Console.WriteLine("Enter operation (deposit/withdraw): ");
            Console.WriteLine("1 - Deposit");
            Console.WriteLine("2 - Withdraw");
            int operationInput = int.Parse(Console.ReadLine());
            Operation operation = (Operation)operationInput;

            switch (operation)
            {
                case Operation.Deposit:
                    Console.WriteLine("Enter amount to deposit: ");
                    decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                    bankAccount.Deposit(depositAmount);
                    break;
                case Operation.Withdraw:
                    Console.WriteLine("Enter amount to withdraw: ");
                    decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                    bankAccount.Withdraw(withdrawAmount);
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
            Console.WriteLine($"Your final balance is: {bankAccount.Balance}");
        }
    }
}
