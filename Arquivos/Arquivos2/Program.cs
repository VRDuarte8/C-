string path = @"D:\VRD\Cursos\Curso C#\C#\Arquivos\Arquivos2\file1.txt";
//FileStream fs = null;
StreamReader sr = null;

try{
    //fs = new FileStream(path, FileMode.Open);
    sr = File.OpenText(path);
    while(!sr.EndOfStream){
        string line = sr.ReadLine();
        System.Console.WriteLine(line);
    }
}
catch (IOException e){
    System.Console.WriteLine("An error ocurred");
    System.Console.WriteLine(e.Message);
}
finally {
    if(sr != null) sr.Close();
    //if(fs != null) fs.Close();
}