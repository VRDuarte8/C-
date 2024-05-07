using System.Globalization;

System.Console.WriteLine("---------- Conta ------------\n");

Conta c = null;

System.Console.Write("Número da conta: ");
int num = int.Parse(Console.ReadLine());
while(num <= 0){
    System.Console.Write("Valor inválido, digite novamente: ");
    num = int.Parse(Console.ReadLine());
}

System.Console.Write("Titular da conta: ");
string titular = Console.ReadLine();
while(titular is null || titular.Length < 1){
    System.Console.Write("Digite um nome: ");
    titular = Console.ReadLine();
}

System.Console.Write("Haverá depósito inicial (s/n)? ");
char dep = char.Parse(Console.ReadLine());
while(dep != 's' && dep != 'S' && dep != 'n' && dep != 'N'){
    System.Console.Write("Haverá depósito inicial (s/n)? ");
    dep = char.Parse(Console.ReadLine());
}

if(dep == 's' || dep == 'S'){
    System.Console.Write("Valor de depósito inicial: ");
    double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    while(saldo < 0){
        System.Console.Write("Digite um valor válido: ");
        saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }
    c = new Conta(num, titular, saldo);

} else if(dep == 'n' || dep == 'N'){
    c = new Conta(num, titular);
}

System.Console.WriteLine();
System.Console.WriteLine("Dados da conta:");
System.Console.WriteLine(c);

System.Console.Write("Valor para depósito: ");
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
c.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
System.Console.WriteLine("Dados da conta atualizados:");
System.Console.WriteLine(c);

System.Console.Write("Valor para saque: ");
c.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
System.Console.WriteLine("Dados da conta atualizados:");
System.Console.WriteLine(c);




