namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var bankAccount1 = new BankAccount();
            Console.WriteLine("Please enter the amount to deposit:");
            
            var deposited = double.Parse(Console.ReadLine());

            bankAccount1.Deposit(deposited);

            Console.WriteLine($"Your new balance is: ${bankAccount1.GetBalance()}");


        }
    }
}