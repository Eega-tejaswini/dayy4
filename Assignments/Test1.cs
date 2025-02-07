
using Assigncalc;

namespace TestProjectcal
{
    [TestClass]
  
    public class CalculatorTests
    {
        private Calculatorr calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculatorr();
        }

        [TestMethod]
        public void Add_ValidNumbers_ReturnsCorrectSum()
        {
            double result = calculator.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_ValidNumbers_ReturnsCorrectDifference()
        {
            double result = calculator.Subtract(10, 4);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Multiply_ValidNumbers_ReturnsCorrectProduct()
        {
            double result = calculator.Multiply(6, 7);
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void Divide_ValidNumbers_ReturnsCorrectQuotient()
        {
            double result = calculator.Divide(10, 2);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsException()
        {
            calculator.Divide(10, 0);
        }

        [TestMethod]
        public void Add_Zero_ReturnsSameNumber()
        {
            double result = calculator.Add(5, 0);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Subtract_SameNumber_ReturnsZero()
        {
            double result = calculator.Subtract(5, 5);
            Assert.AreEqual(0, result);
        }
    }

}

