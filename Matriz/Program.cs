System.Console.Write("Digite a ordem da matriz: ");
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];
int negative = 0;

for (int i = 0; i < n; i++)
{
    System.Console.Write($"Digite a linha {i}: ");
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(values[j]);
        if (mat[i, j] < 0){
            ++negative;
        }
    }
}

System.Console.Write("Diagonal principal: ");
for (int i = 0; i < n; i++)
{
    System.Console.Write(mat[i, i] + " ");
}
System.Console.WriteLine("\nQuantidade de números negativos: " + negative);