using System;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        private string operand1Txt;
        private string operand2Txt;
        private Operator? operation;

        public void AddOperand(string operand)
        {
            ThrowIfNotNumber(operand);
            if (!operation.HasValue)
            {
                operand1Txt += operand;
            }
            else
            {
                operand2Txt += operand;
            }
        }

        public void AddOperator(Operator operation)
        {
            if(!this.operation.HasValue)
            {
                this.operation = operation;
            }
        }

        public double GetResult()
        {
            double result;

            ThrowIfOperationAndOperandsNotConsistent();

            var operand1 = double.Parse(operand1Txt);
            var operand2 = double.Parse(operand2Txt);

            switch (operation)
            {
                case Operator.Plus:
                    result = operand1 + operand2;
                    SetCarryOver(result);
                    break;

                case Operator.Minus:
                    result = operand1 - operand2;
                    SetCarryOver(result);
                    break;

                case Operator.Mol:
                    result = operand1 * operand2;
                    SetCarryOver(result);
                    break;

                case Operator.Div:
                    ThrowIfSecondOperandIsZero();
                    result = operand1 / operand2;
                    SetCarryOver(result);
                    break;

                default:
                    throw new InvalidOperationException();
            }

            return result;
        }

        public void Reset()
        {
            operand1Txt = null;
            operand2Txt = null;
            operation = null;
        }

        public double FlipSign()
        {
            ThrowIfFirstOperandNotSet();
            var result = double.Parse(operand1Txt) * (-1);
            operand1Txt = result.ToString();
            
            return result;
        }

        public double DivideBy100()
        {
            ThrowIfFirstOperandNotSet();
            var result = double.Parse(operand1Txt) / 100;
            operand1Txt = result.ToString();

            return result;
        }

        private void SetCarryOver(double result)
        {
            operand1Txt = result.ToString();
            operand2Txt = null;
            operation = null;
        }

        private void ThrowIfNotNumber(string operand)
        {
            if(!double.TryParse(operand, out var _))
            {
                throw new InvalidOperationException();
            }
        }

        private void ThrowIfOperationAndOperandsNotConsistent()
        {
            if (string.IsNullOrEmpty(operand1Txt) || string.IsNullOrEmpty(operand2Txt) || !operation.HasValue)
            {
                throw new InvalidOperationException();
            }
        }

        private void ThrowIfFirstOperandNotSet()
        {
            if (string.IsNullOrEmpty(operand1Txt))
            {
                throw new InvalidOperationException();
            }
        }

        private void ThrowIfSecondOperandIsZero()
        {
            if(double.Parse(operand2Txt) == 0)
            {
                throw new InvalidOperationException();
            }
        }
    }
}


