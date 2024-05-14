using System;
using System.Globalization;

System.Console.WriteLine("Enter client data: ");
System.Console.Write("Name: ");
string name = Console.ReadLine();
System.Console.Write("Email: ");
string email = Console.ReadLine();
System.Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Client client = new(name, email, birthDate);

System.Console.WriteLine("Enter order data: ");
System.Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
System.Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

Order order = new(DateTime.Now, status, client);

for (int i = 1; i <= n; i++)
{
    System.Console.WriteLine($"Enter the #{i} item data: ");
    System.Console.Write("Product name: ");
    string prodName = Console.ReadLine();
    System.Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    System.Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine()); 
    Product product = new Product(prodName, price);
    OrderItem orderItem = new(quantity, price, product);
    order.AddItem(orderItem);
}

System.Console.WriteLine();
System.Console.WriteLine(order);
