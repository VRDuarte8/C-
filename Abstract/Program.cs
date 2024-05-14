using System.Globalization;

System.Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

List<Pessoa> list = new();

for (int i = 1; i <= n; i++)
{
    System.Console.WriteLine($"Tax payer #{i} data: ");
    System.Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine());
    System.Console.Write("Name: ");
    string nome = Console.ReadLine();
    System.Console.Write("Anual income: ");
    double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (type == 'i')
    {
        System.Console.Write("Health expenditures: ");
        double gastos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new PessoaFisica(nome, renda, gastos));
    } else
    {
        System.Console.Write("Number of employees: ");
        int numEmp = int.Parse(Console.ReadLine());
        list.Add(new PessoaJuridica(nome, renda, numEmp));
    }
}

System.Console.WriteLine();
System.Console.WriteLine("Taxes Paid");
double sum = 0;
foreach (Pessoa p in list)
{
    System.Console.WriteLine(p);
    sum += p.Imposto();
}
System.Console.WriteLine("\nTOTAL TAXES: $" + sum.ToString("F2", CultureInfo.InvariantCulture));

