using System.Globalization;

System.Console.WriteLine("Entre os dados do produto: ");
System.Console.Write("Nome: ");
string nome = Console.ReadLine();
System.Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
/*System.Console.Write("Quantidade no estoque: ");
int quantidade = int.Parse(Console.ReadLine());*/

Produto p = new Produto(nome, preco/*, quantidade*/);

//Produto p2 = new Produto();

/*
Produto p3 = new Produto{
    Nome = "PS5",
    Preco = 500.00,
    Quantidade = 5
};*/

System.Console.WriteLine("Dados do produto: " + p3);

System.Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
p.AdicionarProdutos(int.Parse(Console.ReadLine()));
System.Console.WriteLine("Dados atualizados: " + p);

System.Console.Write("Digite o número de produtos a ser removido ao estoque: ");
p.RemoverProdutos(int.Parse(Console.ReadLine()));
System.Console.WriteLine("Dados atualizados: " + p);
