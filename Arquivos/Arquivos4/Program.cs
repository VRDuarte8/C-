string path = @"D:\VRD\Cursos\Curso C#\C#\Arquivos\Arquivos4\myfolder";

try
{
    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    System.Console.WriteLine("FOLDERS:");
    foreach (string s in folders)
    {
        System.Console.WriteLine(s);
    }

    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    System.Console.WriteLine("FILES:");
    foreach (string s in files)
    {
        System.Console.WriteLine(s);
    }

    Directory.CreateDirectory(path + @"\newfolder");
}
catch (IOException e)
{
    System.Console.WriteLine("An error occurred");
    System.Console.WriteLine(e.Message);
}