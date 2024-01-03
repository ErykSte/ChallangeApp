namespace ChallangeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void UserNameDifferenceTest()
        {
            //arrange
            var user1 = GetUser("Marek", "Jałowski", 28);
            var user2 = GetUser("Damian", "Kaczka", 28);
            var user3 = GetUser("Marek", "Kaczka", 35);

            //act


            //assert
            Assert.AreNotEqual(user1.name, user2.name);
            Assert.AreNotEqual(user3.name, user2.name);
            Assert.AreEqual(user1.name, user3.name);
        }

        [Test]
        public void UserSurenameDifferenceTest()
        {
            //arrange
            var user1 = GetUser("Marek", "Jałowski", 28);
            var user2 = GetUser("Damian", "Kaczka", 28);
            var user3 = GetUser("Marek", "Kaczka", 35);

            //act


            //assert
            Assert.AreNotEqual(user1.surname, user2.surname);
            Assert.AreEqual(user3.surname, user2.surname);
            Assert.AreNotEqual(user1.surname, user3.surname);
        }

        [Test]
        public void UserAgeDifferenceTest()
        {
            //arrange
            var user1 = GetUser("Marek", "Jałowski", 28);
            var user2 = GetUser("Damian", "Kaczka", 28);
            var user3 = GetUser("Marek", "Kaczka", 35);

            //act
            

            //assert
            Assert.AreEqual(user1.age, user2.age);
            Assert.AreNotEqual(user3.age, user2.age);
            Assert.AreNotEqual(user1.age, user3.age);

        }

        private User GetUser(string name, string surname, int age)
        {
            return new User(name, surname, age);
        }
    }
}
