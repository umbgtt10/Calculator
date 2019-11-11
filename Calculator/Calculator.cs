using System;

namespace Calculator
{
    public class Calculator : ICalculator
    {
        private double? operand1;
        private double? operand2;
        private Operator? operand;

        public void AddOperand(double operand)
        {
            if(!operand1.HasValue)
            {
                operand1 = operand;
            }
            else if(!operand2.HasValue)
            {
                operand2 = operand;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void AddOperator(Operator operation)
        {
            if(!operand.HasValue)
            {
                operand = operation;
            }
        }

        public double GetResult()
        {
            if(!operand1.HasValue || !operand2.HasValue || !operand.HasValue)
            {
                throw new InvalidOperationException();
            }

            double result;

            switch(operand)
            {
                case Operator.Plus:
                    result = operand1.Value + operand2.Value;
                    break;

                default:
                    throw new InvalidOperationException();
            }

            SetCarryOver(result);

            return result;
        }

        private void SetCarryOver(double result)
        {
            operand1 = result;
            operand2 = null;
            operand = null;
        }
    }
}

