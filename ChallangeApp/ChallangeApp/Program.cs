//Zadanie domowe dzie� 9.

using ChallangeApp;

var employee1 = new Employee("B�a�ej", "Dudek");
employee1.AddGrade(5);
employee1.AddGrade(7);
employee1.AddGrade(8);
var statistics = employee1.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max; {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");