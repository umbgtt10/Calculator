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
        public void GetResult_NoOperandsSet_ReturnsZero()
        {
            // Arange
            var expectedResult = 0;

            // Act
            var resut = this.testee.GetResult();

            // Assert
            Assert.AreEqual(expectedResult, resut);
        }

        [TestMethod]
        public void GetResult_AddSingleOperand_ThenAddOperator_NoSecondOperandSet_ReturnsFurstOperand()
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
        public void GetResult_AddSingleOperand_ThenAddOperator_ThenAddSingleOperand_ReturnsCorrectResult()
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
        public void GetResult_ThenAddOperator_ThenChangeOperator_ThenAddSecondOperator_ReturnsCorrectResult()
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
        public void GetResult_AddSingleOperand_ThenMinusOperator_ThenAddSingleOperand_ReturnsCorrectResult()
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
        public void GetResult_AddSingleOperand_ThenMultiplicationOperator_ThenAddSingleOperand_ReturnsCorrectResult()
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
        public void GetResult_AddSingleOperand_ThenDivisionOperator_ThenAddSingleOperand_ReturnsCorrectResult()
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
        public void GetResult_AddSingleOperand_ThenFlipSign_ReturnsCorrectResult()
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
        public void GetResult_AddMultipleOperands_ThenDivideBy100_ReturnsCorrectResult()
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
        public void GetResult_AddMultipleOperands_ThenPlusOperator_ThenAddMultipleOperands_ReturnsCorrectResult()
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
        public void GetResult_AddMultipleOperands_ThenMinusOperator_ThenAddMultipleOperands_ReturnsCorrectResult()
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
        public void GetResult_AddMultipleOperands_ThenMultiplicationOperator_ThenAddMultipleOperands_ReturnsCorrectResult()
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
        public void GetResult_AddMultipleOperands_ThenDivisionOperator_ThenAddSingleOperand_ReturnsCorrectResult()
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
        public void GetResult_AddSingleOperandWithComma_ThenPlusOperator_ThenAddSingleOperand_ReturnsCorrectResult()
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
        public void GetResult_AddSingleOperandWithComma_ThenPlusOperator_ThenAddSingleOperandWithComma_ReturnsCorrectResult()
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
        public void GetResult_AddSingleOperandWithComma_ThenPlusOperator_ThenNoSecondOperand_ReturnsCorrectResult()
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
        public void GetResult_AddSingleOperandWithComma_ReturnsFirstOperatorResult()
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

