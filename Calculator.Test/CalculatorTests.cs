using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator testee;

        public CalculatorTests()
        {
            this.testee = new Calculator();
        }

        [TestMethod]
        public void AddOperand_ThenAddOperator_ThenAddOperand_ThenGetResult()
        {
            // Arange
            var operand1 = 5;
            var operand2 = 10;
            var operation = Operator.Plus;
            var expectedResult = 15;
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);
            this.testee.AddOperand(operand2);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }
    }
}

