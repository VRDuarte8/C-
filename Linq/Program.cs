using System.Globalization;

try
{
    Console.Write("Enter full file path: ");
    string path = Console.ReadLine();

    List<Employee> employees = new();

    using (StreamReader sr = File.OpenText(path)){
        while(!sr.EndOfStream){
            string[] fields = sr.ReadLine().Split(',');
            string name = fields[0];
            string email = fields[1];
            double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
            employees.Add(new Employee(name, email, salary));
        }
    }

    System.Console.Write("Enter Salary: ");
    double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
    var emails = employees.Where(p => p.Salary > sal).OrderBy(p => p.Email).Select(p => p.Email);

    System.Console.WriteLine($"Email of people whose salary is more than {sal.ToString("F2", CultureInfo.InvariantCulture)}:");
    foreach (string email in emails)
    {
        System.Console.WriteLine(email);
    }

    var sum = employees.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
    System.Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
}
catch(IOException e){
    System.Console.WriteLine("An error occurred");
    System.Console.WriteLine(e.Message);
}
