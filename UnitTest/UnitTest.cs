using Beregner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodAverageIncome()
        {
            // Arrange
            double totalIncome = 250000;
            double MonthToDate = 4;
            double expected = 62500;
            //Act
            double actual = Calculator.AverageIncome(totalIncome, MonthToDate);
            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Income not calculated correctly");
        }
        [TestMethod]
        public void TestMethodAverageConsumption()
        {
            // Arrange
            double totalIncome = 170000;
            double MonthToDate = 4;
            double expected = 42500;
            //Act
            double actual = Calculator.AverageConsumption(totalIncome, MonthToDate);
            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Consumption not calculated correctly");
        }
        [TestMethod]
        public void TestMethodSavingsRate()
        {
            // Arrange
            double totalIncome = 250000;
            double totalConsumption = 170000;
            double expected = 0.32;
            //Act
            double actual = Calculator.SavingsRate(totalIncome, totalConsumption);
            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Rate not calculated correctly");
        }
    }
}
