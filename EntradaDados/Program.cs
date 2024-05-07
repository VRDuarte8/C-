/*
string? frase = Console.ReadLine();
string? x = Console.ReadLine();
string? y = Console.ReadLine();
string? z = Console.ReadLine();

System.Console.WriteLine("\nVocê digitou: ");
System.Console.WriteLine(frase);
System.Console.WriteLine(x);
System.Console.WriteLine(y);
System.Console.WriteLine(z);

string[] v = Console.ReadLine().Split(' ');
string a = v[0];
string b = v[1];
string c = v[2];

System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c);*/

using System.Globalization;

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

string[] vet = Console.ReadLine().Split(' ');
string nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);


System.Console.WriteLine("\nVocê digitou: ");
System.Console.WriteLine(n1);
System.Console.WriteLine(ch);
System.Console.WriteLine(n2);
System.Console.WriteLine(nome);
System.Console.WriteLine(sexo);
System.Console.WriteLine(idade);
System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));