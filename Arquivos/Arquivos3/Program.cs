string sourcePath = @"D:\VRD\Cursos\Curso C#\C#\Arquivos\Arquivos3\file1.txt";
string targetPath = @"D:\VRD\Cursos\Curso C#\C#\Arquivos\Arquivos3\file2.txt";

try{
    //using(FileStream fs = new(path, FileMode.Open)){
    using(StreamReader sr = File.OpenText(sourcePath)){
        while(!sr.EndOfStream){
            string line = sr.ReadLine();
            System.Console.WriteLine(line);
        }
    }
    //}

    string[] lines = File.ReadAllLines(sourcePath);

    using(StreamWriter sw = File.AppendText(targetPath)){
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch(IOException e){
    System.Console.WriteLine("An error occurred");
    System.Console.WriteLine(e.Message);
}
