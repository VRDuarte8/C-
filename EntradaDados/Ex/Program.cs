using System.Globalization;

System.Console.WriteLine("Entre com seu nome completo: ");
string nome = Console.ReadLine();

System.Console.WriteLine("\nQuantos quartos tem na sua casa?");
int qu = int.Parse(Console.ReadLine());

System.Console.WriteLine("\nEntre com o preço de um produto: ");
double pr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine("\nEntre seu último nome, idade e altura (mesma linha): ");
string[] vet = Console.ReadLine().Split(' ');
string un = vet[0];
int id = int.Parse(vet[1]);
double al = double.Parse(vet[2], CultureInfo.InvariantCulture);

System.Console.WriteLine("\nDados: ");
System.Console.WriteLine(nome);
System.Console.WriteLine(qu);
System.Console.WriteLine(pr.ToString("F2", CultureInfo.InvariantCulture));
System.Console.WriteLine(un);
System.Console.WriteLine(id);
System.Console.WriteLine(al.ToString("F2", CultureInfo.InvariantCulture));
