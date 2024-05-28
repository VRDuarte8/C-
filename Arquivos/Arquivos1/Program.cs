string sourcePath = @"D:\VRD\Cursos\Curso C#\C#\Arquivos\Arquivos1\file1.txt";
string targetPath = @"D:\VRD\Cursos\Curso C#\C#\Arquivos\Arquivos1\file2.txt";

try{
    FileInfo fileInfo = new(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        System.Console.WriteLine(line);
    }
}
catch (IOException e){
    System.Console.WriteLine("An error ocurred");
    System.Console.WriteLine(e.Message);
}