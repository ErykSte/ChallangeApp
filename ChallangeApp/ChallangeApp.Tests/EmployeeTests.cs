//Zadanie domowe dzieñ 9.
using NUnit.Framework;
namespace ChallangeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhennGetStatisticsCalled_ShouldReturnCorrectMax()
        {
            //arrange
            var employee1 = new Employee("B³a¿ej", "Dudek");
            employee1.AddGrade(5);
            employee1.AddGrade(7);
            employee1.AddGrade(8);

            //act
            var statistics = employee1.GetStatistics();

            //assert
            ClassicAssert.AreEqual(8,statistics.Max);

        }

        [Test]
        public void WhennGetStatisticsCalled_ShouldReturnCorrectAverage()
        {
            //arrange
            var employee1 = new Employee("B³a¿ej", "Dudek");
            employee1.AddGrade(5);
            employee1.AddGrade(7);
            employee1.AddGrade(8);

            //act
            var statistics = employee1.GetStatistics();

            //assert
            ClassicAssert.AreEqual(Math.Round(6.67, 2), Math.Round(statistics.Average, 2));

        }

        [Test]
        public void WhennGetStatisticsCalled_ShouldReturnCorrectMin()
        {
            //arrange
            var employee1 = new Employee("B³a¿ej", "Dudek");
            employee1.AddGrade(5);
            employee1.AddGrade(6);
            employee1.AddGrade(7);

            //act
            var statistics = employee1.GetStatistics();

            //assert
            ClassicAssert.AreEqual(5, statistics.Min);

        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee(name, surname);
        }
    }
}