Console.Clear();
System.Console.WriteLine("Enter contract data");
System.Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
System.Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());
System.Console.Write("Contract value: ");
double totalValue = double.Parse(Console.ReadLine());
Contract contract = new(number, date, totalValue);

System.Console.Write("Enter number of installments: ");
int months = int.Parse(Console.ReadLine());
ContractService contractService = new ContractService(new PaypalService());
contractService.ProcessContract(contract, months);

System.Console.WriteLine("Installments:");
foreach (Installment installment in contract.Installments)
{
    System.Console.WriteLine(installment);
}
