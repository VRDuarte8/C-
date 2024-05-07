using System.Globalization;

List<Employee> list = new List<Employee>();

System.Console.Write("How many employees will be registered? ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++){
    System.Console.WriteLine("Employee #" + i);
    System.Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    System.Console.Write("Name: ");
    string name = Console.ReadLine();
    System.Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    list.Add(new Employee(id, name, salary));
}

System.Console.Write("Enter the employee id that will have salary increase: ");
int idInc = int.Parse(Console.ReadLine());
Employee emp = list.Find(x => x.Id == idInc);
if(emp is not null){
    System.Console.Write("Enter the percentage: ");
    double perc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.IncreaseSalary(perc);
} else {
    System.Console.WriteLine("This id not exist!");
}

System.Console.WriteLine("-------------------------------");
System.Console.WriteLine("Updated list of employees: ");
foreach (Employee e in list){
    System.Console.WriteLine(e);
}




