//Zadanie domowe dzieñ 7.
namespace ChallangeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenTwoNumberAdded_ShouldReturnSum()
        {
            //arrange
            var employee = new Employee("Marek", "Ja³owski", 23);
            employee.AddScore(5);
            employee.AddScore(6);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(11, result);

        }
    }
}