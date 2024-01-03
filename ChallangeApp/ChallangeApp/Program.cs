//Zadanie domowe dzieñ 7.
using ChallangeApp;

User user1 = new User("Marek", "Ja³owski", 23);
User user2 = new User("Damian", "Wiœniewski", 28);
User user3 = new User("Aneta", "Kaczka", 35);

user1.AddScore(5);
user1.AddScore(6);
user1.AddScore(3);
user1.AddScore(4);
user1.AddScore(8);

user2.AddScore(1);
user2.AddScore(3);
user2.AddScore(9);
user2.AddScore(4);
user2.AddScore(7);

user3.AddScore(8);
user3.AddScore(9);
user3.AddScore(1);
user3.AddScore(3);
user3.AddScore(2);


List<User> users = new List<User>()
{
    user1, user2, user3
};

int maxResult = -1;
User userWithMaxResult = null; 

foreach (var user in users)
{
    if (user.Result > maxResult)
    {
        userWithMaxResult = user;
        maxResult = user.Result;
    }
}

Console.WriteLine(user1.name + " " + user1.surname + " " + user1.age + " | " + user1.Result + "pkt.");
Console.WriteLine(user2.name + " " + user2.surname + " " + user2.age + " | " + user2.Result + "pkt.");
Console.WriteLine(user3.name + " " + user3.surname + " " + user3.age + " | " + user3.Result + "pkt.");

Console.WriteLine("(Pracownik z najwieksz¹ ilosci¹ punktów):");

Console.WriteLine(userWithMaxResult.name + " " + userWithMaxResult.surname + " " + "lat:" + userWithMaxResult.age + " | " + userWithMaxResult.Result  + "pkt.");