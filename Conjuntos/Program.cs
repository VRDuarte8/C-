System.Console.Write("How many students for couse A? ");
int n = int.Parse(Console.ReadLine());
HashSet<int> cA = new();
for (int i = 1; i <= n; i++)
{
    System.Console.Write($"Student {i}: ");
    cA.Add(int.Parse(Console.ReadLine()));
}

System.Console.Write("How many students for couse B? ");
n = int.Parse(Console.ReadLine());
HashSet<int> cB = new();
for (int i = 1; i <= n; i++)
{
    System.Console.Write($"Student {i}: ");
    cB.Add(int.Parse(Console.ReadLine()));
}

System.Console.Write("How many students for couse C? ");
n = int.Parse(Console.ReadLine());
HashSet<int> cC = new();
for (int i = 1; i <= n; i++)
{
    System.Console.Write($"Student {i}: ");
    cC.Add(int.Parse(Console.ReadLine()));
}


HashSet<int> all = new(cA);
all.UnionWith(cB);
all.UnionWith(cC);
System.Console.Write("Total students: " + all.Count);