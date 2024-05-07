using System.Globalization;

int n = int.Parse(Console.ReadLine());

Product[] vect = new Product[n];
double sum = 0.0;

for(int i = 0; i < n; i++){
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vect[i] = new Product { Name = name, Price = price };
    sum += vect[i].Price;
}

double avg = sum / n;
System.Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));

