using System.Globalization;

System.Console.Write("Enter file full path: ");
string sourceFilePath = Console.ReadLine();

try
{
    string[] lines = File.ReadAllLines(sourceFilePath);

    string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
    string targetFolderPath = sourceFolderPath + @"\out";
    string targetFilePath = targetFolderPath + @"\summary.csv";

    Directory.CreateDirectory(targetFolderPath);

    using(StreamWriter sw = File.AppendText(targetFilePath)){
        foreach (string line in lines)
        {
            string[] fields = line.Split(',');
            string name = fields[0];
            double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
            int Quantity = int.Parse(fields[2]);

            Product p = new(name, price, Quantity);

            sw.WriteLine($"{p.Name},{p.Total().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }

}
catch (IOException e)
{
    System.Console.WriteLine("An error ocurred");
    System.Console.WriteLine(e.Message);
}