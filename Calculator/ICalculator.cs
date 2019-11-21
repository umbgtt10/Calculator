namespace Calculator
{
    public interface ICalculator
    {
        void AddOperator(Operator operation);

        void AddOperand(string operand);

        double GetResult();

        double FlipSign();
        double DivideBy100();

        void Reset();
    }
}

