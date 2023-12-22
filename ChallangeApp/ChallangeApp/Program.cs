//Zadanie domowe dzieñ 6 :)
using ChallangeApp;

Employee employee1 = new Employee("Marek", "Ja³owski", 23);
Employee employee2 = new Employee("Damian", "Wiœniewski", 28);
Employee employee3 = new Employee("Aneta", "Kaczka", 35);

employee1.AddScore(5);
employee1.AddScore(6);
employee1.AddScore(3);
employee1.AddScore(4);
employee1.AddScore(8);

employee2.AddScore(1);
employee2.AddScore(3);
employee2.AddScore(9);
employee2.AddScore(4);
employee2.AddScore(7);

employee3.AddScore(8);
employee3.AddScore(9);
employee3.AddScore(1);
employee3.AddScore(3);
employee3.AddScore(2);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null; 

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine(employee1.name + " " + employee1.surename + " " + employee1.age + " | " + employee1.Result + "pkt.");
Console.WriteLine(employee2.name + " " + employee2.surename + " " + employee2.age + " | " + employee2.Result + "pkt.");
Console.WriteLine(employee3.name + " " + employee3.surename + " " + employee3.age + " | " + employee3.Result + "pkt.");

Console.WriteLine("(Pracownik z najwieksz¹ ilosci¹ punktów):");

Console.WriteLine(employeeWithMaxResult.name + " " + employeeWithMaxResult.surename + " " + "lat:" + employeeWithMaxResult.age + " | " + employeeWithMaxResult.Result  + "pkt.");