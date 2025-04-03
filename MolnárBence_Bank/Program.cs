namespace MolnárBence_Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OwnerR owner1 = new("John Doe");
            Bank bank = new(10);

            var account1 = bank.NewAccount(owner1, 1000);
            account1.Deposit(500);
            Console.WriteLine($"Balance: {account1.Balance}");

            var card1 = account1.NewCard("1234-5678-9012");
            Console.WriteLine($"Card Purchase Success: {card1.Purchase(200)}");
            Console.WriteLine($"Balance after purchase: {account1.Balance}");
        }
    }
}
