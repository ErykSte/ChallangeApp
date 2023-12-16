// Zadanie domowe dzień 4

var name = "Ewa";
var sex = "Kobieta";
var age = 17;

if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}

else if (sex != "Kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
