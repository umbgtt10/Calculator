namespace Calculator
{
    public interface ICalculator
    {
        void AddOperator(Operator operation);
        void AddOperand(double operand);
        double GetResult();
    }
}

