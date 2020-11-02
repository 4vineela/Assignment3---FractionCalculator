using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.UnitTest
{
    [TestClass]
    public class FractionCalculationTest
    {
        [TestMethod]
        public void Test_Fraction_Addition()
        {
            //Arrange
            _ = new Fraction();
            Fraction first = new Fraction(4, 1);
            Fraction second = new Fraction(5, 9);

            //Act
            Fraction result = first.Addition(second);

            //Assert
            Assert.AreEqual(41, result.Numerator);
            Assert.AreEqual(9, result.Denominator);
        }

        [TestMethod]
        public void Test_Fraction_Subtraction()
        {
            //Arrange
            var testfraction = new Fraction();
            Fraction first = new Fraction(20, 10);
            Fraction second = new Fraction(-9, 5);

            //Act
            Fraction result = first.Subtraction(second);

            //Assert
            Assert.AreEqual(190, result.Numerator);
            Assert.AreEqual(50, result.Denominator);
        }

        [TestMethod]
        public void Test_Fraction_Multiplication()
        {
            //Arrange
            var testfraction = new Fraction();
            Fraction first = new Fraction(-18, 3);
            Fraction second = new Fraction(8, -2);

            //Act
            Fraction result = first.Multiplication(second);

            //Assert
            Assert.AreEqual(-144, result.Numerator);
            Assert.AreEqual(-6, result.Denominator);
        }
        [TestMethod]
        public void Test_Fraction_Division()
        {
            //Arrange
            var testfraction = new Fraction();
            Fraction first = new Fraction(-17, 18);
            Fraction second = new Fraction(6, -9);

            //Act
            Fraction result = first.Division(second);

            //Assert
            Assert.AreEqual(153, result.Numerator);
            Assert.AreEqual(108, result.Denominator);
        }
    }
}
