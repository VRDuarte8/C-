System.Console.Write("Digite a Quantidade de linhas e colunas da matriz (l c): ");
string[] tam = Console.ReadLine().Split(' ');

int l = int.Parse(tam[0]);
int c = int.Parse(tam[1]);
int[,] mat = new int[l, c];

for (int i = 0; i < l; i++)
{
    System.Console.Write($"Digite a linha {i+1}: ");
    string[] values = Console.ReadLine().Split(' ');
    for (int j = 0; j < c; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

System.Console.Write("Digite o número buscado: ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < l; i++){
    for (int j = 0; j < c; j++){
        if(mat[i, j] == num){
            System.Console.WriteLine($"Position {i},{j}:");
            if (j > 0){
                System.Console.WriteLine("Left: " + mat[i, j-1]);
            }
            if (i > 0){
                System.Console.WriteLine("Up: " + mat[i-1, j]);
            }
            if (j < c-1){
                System.Console.WriteLine("Right: " + mat[i, j+1]);
            }
            if (i < l-1){
                System.Console.WriteLine("Down: " + mat[i+1, j]);
            }
        }
    }
}