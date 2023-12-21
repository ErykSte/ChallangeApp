//Zadanie domowe dzieñ 6 :)
using ChallangeApp;

Employee employee1 = new Employee("Marek", "qwerty", "23");
Employee employee2 = new Employee("Damian", "qwerty", "28");
Employee employee3 = new Employee("Aneta", "qwerty", "35");

var name1 = employee1.Login;
var name2 = employee2.Login;
var name3 = employee3.Login;

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
    if(employee1.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
    else if (employee2.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
    else if (employee3.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Pracownik z najwy¿sz¹ punktacj¹ - " + employees + employee1.Login);