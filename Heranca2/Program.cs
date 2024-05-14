using System.Globalization;

System.Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());
List<Product> list = new();

for (int i = 1; i <= n; i++)
{
    System.Console.Write($"Product #{i} data: ");
    System.Console.Write("Common, used or imported (c/u/i)? ");
    char type = char.Parse(Console.ReadLine());
    System.Console.Write("Name: ");
    string name = Console.ReadLine();
    System.Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (type == 'i')
    {
        System.Console.Write("Customs fee: ");
        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new ImportedProduct(name, price, fee));
    } else if (type == 'u')
    {
        System.Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manDate = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, manDate));
    } else
    {
        list.Add(new Product(name, price));
    }
}

System.Console.WriteLine("\nPrice Tags: ");
foreach (Product p in list)
{
    System.Console.WriteLine(p.PriceTag());
}