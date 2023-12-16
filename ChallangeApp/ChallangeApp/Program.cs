// Zadanie domowe dzień 4

var Name = "Andrzej";
var Sex = "Mężczyzna";
var Age = 17;

if (Sex == "Kobieta" && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (Name == "Ewa" && Age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
if (Sex == "Mężczyzna" && Age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
if (!(Age == 17 && Sex == "Mężczyzna" && Name == "Andrzej"))
{
    Console.WriteLine();
}