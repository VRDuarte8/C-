using System.Globalization;

Console.Write("Enter the number of employees: ");
int n = int.Parse(Console.ReadLine());
List<Employee> list = new();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee #{i} data: ");
    Console.Write("Outsourced (y/n)? ");
    char outsourced = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (outsourced == 'y' || outsourced == 'Y')
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    } else
    {
        list.Add(new Employee(name, hours, valuePerHour));
    }
}

System.Console.WriteLine();
System.Console.WriteLine("Payments: ");
foreach (Employee e in list)
{
    System.Console.WriteLine(e.Name + " - $" + e.Payment().ToString("F2", CultureInfo.InvariantCulture));
}