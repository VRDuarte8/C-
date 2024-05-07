// See https://aka.ms/new-console-template for more information
//using System.Globalization;

//char gen = 'M';
int idade = 23;
double saldo = 10.35784;
string nome = "Vinicius";

/*
Console.WriteLine("Bom Dia!");
Console.Write("Boa Tarde!");
Console.WriteLine("Boa Noite!");

Console.WriteLine(gen);
Console.WriteLine(idade);
Console.WriteLine(saldo.ToString("F2"));
Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine(nome);*/

Console.WriteLine("{0} tem {1} anos e tem saldo igual a R${2:F2}", nome, idade, saldo);

Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a R${saldo:F2}");

Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a R$" + saldo.ToString("F2"));
