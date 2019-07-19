using FirstUnitTerst;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Divide()
        {
            //Arrange
            int expected = 5;
            int numerator = 20;
            int denominator = 4;

            //Act
            int actual = Calculator.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
