using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            //arrang
            SalaryCalculator sc = new SalaryCalculator();
            //act
            decimal annualSalary = sc.GetnnualSallary(50);
            // Assert
            Assert.AreEqual(104000, annualSalary);

        }
        [TestMethod]
        public  void HourlyWageTest()
        {
            SalaryCalculator sc = new SalaryCalculator();

            decimal horewage = sc.horlywage(52000);
            Assert.AreEqual(25, horewage);

        }
    }
}
