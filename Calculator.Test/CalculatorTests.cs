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
        public void NoOperandsSet_GetResult_ReturnsZero()
        {
            // Arange
            var expectedResult = 0;

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddSingleOperand_ThenAddOperator_NoSecondOperandSet_ThenGetResult_ReturnsFurstOpernad()
        {
            // Arange
            var operand1 = "5";
            var operation = Operator.Plus;
            var expectedResult = 5;
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddSingleOperand_ThenAddOperator_ThenAddSingleOperand_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "5";
            var operand2 = "10";
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

        [TestMethod]
        public void AddSingleOperand_ThenAddOperator_ThenChangeOperator_ThenAddSecondOperator_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "5";
            var operand2 = "10";
            var operation1 = Operator.Plus;
            var operation2 = Operator.Multi;
            var expectedResult = 50;
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation1);
            this.testee.AddOperator(operation2);
            this.testee.AddOperand(operand2);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddSingleOperand_ThenMinusOperator_ThenAddSingleOperand_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "5";
            var operand2 = "10";
            var operation = Operator.Minus;
            var expectedResult = -5;
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);
            this.testee.AddOperand(operand2);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddSingleOperand_ThenMultiplicationOperator_ThenAddSingleOperand_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "5";
            var operand2 = "10";
            var operation = Operator.Multi;
            var expectedResult = 50;
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);
            this.testee.AddOperand(operand2);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddSingleOperand_ThenDivisionOperator_ThenAddSingleOperand_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "50";
            var operand2 = "10";
            var operation = Operator.Div;
            var expectedResult = 5;
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);
            this.testee.AddOperand(operand2);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddSingleOperand_ThenFlipSign_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "50";
            var expectedResult = -50;
            this.testee.AddOperand(operand1);

            // Act
            var resut = this.testee.FlipSign();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddMultipleOperands_ThenDivideBy100_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "50000";
            var expectedResult = 500;
            this.testee.AddOperand(operand1);

            // Act
            var resut = this.testee.DivideBy100();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddMultipleOperands_ThenPlusOperator_ThenAddMultipleOperands_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "3";
            var operand2 = "9";
            var operation = Operator.Minus;
            var expectedResult = 234;
            this.testee.AddOperand(operand1);
            this.testee.AddOperand(operand1);
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);
            this.testee.AddOperand(operand2);
            this.testee.AddOperand(operand2);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddMultipleOperands_ThenMinusOperator_ThenAddMultipleOperands_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "3";
            var operand2 = "9";
            var operation = Operator.Minus;
            var expectedResult = 234;
            this.testee.AddOperand(operand1);
            this.testee.AddOperand(operand1);
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);
            this.testee.AddOperand(operand2);
            this.testee.AddOperand(operand2);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddMultipleOperands_ThenMultiplicationOperator_ThenAddMultipleOperands_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "2";
            var operand2 = "3";
            var operation = Operator.Multi;
            var expectedResult = 7326;
            this.testee.AddOperand(operand1);
            this.testee.AddOperand(operand1);
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);
            this.testee.AddOperand(operand2);
            this.testee.AddOperand(operand2);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddMultipleOperands_ThenDivisionOperator_ThenAddSingleOperand_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "5";
            var operand2 = "5";
            var operation = Operator.Div;
            var expectedResult = 111;
            this.testee.AddOperand(operand1);
            this.testee.AddOperand(operand1);
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);
            this.testee.AddOperand(operand2);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddSingleOperandWithComma_ThenPlusOperator_ThenAddSingleOperand_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "5";
            var operand2 = "5";
            var operation = Operator.Plus;
            var expectedResult = 10.5;
            this.testee.AddOperand(operand1);
            this.testee.AddComma();
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);
            this.testee.AddOperand(operand2);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddSingleOperandWithComma_ThenPlusOperator_ThenAddSingleOperandWithComma_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "5";
            var operand2 = "5";
            var operation = Operator.Plus;
            var expectedResult = 11;
            this.testee.AddOperand(operand1);
            this.testee.AddComma();
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);
            this.testee.AddOperand(operand2);
            this.testee.AddComma();
            this.testee.AddOperand(operand2);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddSingleOperandWithComma_ThenPlusOperator_ThenNoSecondOperand_ThenGetResult_ReturnsCorrectResult()
        {
            // Arange
            var operand1 = "5";
            var operation = Operator.Plus;
            var expectedResult = 5.5;
            this.testee.AddOperand(operand1);
            this.testee.AddComma();
            this.testee.AddOperand(operand1);
            this.testee.AddOperator(operation);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void AddSingleOperandWithComma_ThenGetResult_ReturnsFirstOperatorResult()
        {
            // Arange
            var operand1 = "5";
            var expectedResult = 5.5;
            this.testee.AddOperand(operand1);
            this.testee.AddComma();
            this.testee.AddOperand(operand1);

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }
    }
}

