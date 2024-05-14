using System.Globalization;

try
{
    System.Console.WriteLine("Enter account data");
    System.Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    System.Console.Write("Holder: ");
    string holder = Console.ReadLine();
    System.Console.Write("Initial balance: ");
    double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    System.Console.Write("Withdraw limit: ");
    double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Account account = new(number, holder, initialBalance, limit);

    System.Console.WriteLine();
    System.Console.Write("Enter amount for withdraw: ");
    account.Withdraw(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
} catch (DomainException e){
    System.Console.WriteLine("Withdraw error: " + e.Message);
} catch (FormatException e){
    System.Console.WriteLine("Format error: " + e.Message);
} catch (Exception e){
    System.Console.WriteLine("Unexpected error: " + e.Message);
}