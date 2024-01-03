//Zadanie domowe dzieñ 7.
namespace ChallangeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectTwoScoreAdded_ShouldCorrectResult()
        {
            //arrange
            var user1 = new User("Marek", "Ja³owski", 23);
            user1.AddScore(18);
            user1.AddScore(9);
            user1.AddScore(-5);
            user1.AddScore(-20);

            var user2 = new User("Damian", "Wiœniewski", 28);
            user2.AddScore(3);
            user2.AddScore(20);
            user2.AddScore(7);
            user2.AddScore(-16);

            var user3 = new User("Aneta", "Kaczka", 35);
            user3.AddScore(5);
            user3.AddScore(25);
            user3.AddScore(-4);
            user3.AddScore(-19);

            //act
            var result1 = user1.Result;
            var result2 = user2.Result;
            var result3 = user3.Result;

            //assert
            Assert.AreEqual(2, result1);
            Assert.AreEqual(14, result2);
            Assert.AreEqual(7, result3);

        }
    }
}