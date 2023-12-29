//Zadanie domowe dzieñ 7.
namespace ChallangeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenTwoNumberAdded_ShouldReturnSum()
        {
            //arrange
            var user = new User("Marek", "Ja³owski", 23);
            user.AddScore(5);
            user.AddScore(6);

            //act
            var result = user.Result;

            //assert
            Assert.AreEqual(11, result);

        }
    }
}